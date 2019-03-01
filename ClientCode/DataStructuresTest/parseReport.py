import re
import sys
import os
import time
import subprocess
import argparse
import collections
import pprint
import csv
#from htmlentitydefs import name2codepoint
#import codecs
from bs4 import BeautifulSoup

# Our usage of subprocess seems to require Python 2.7+
# if sys.version_info.major == 2 and sys.version_info.minor < 7:
# 	print("Your python version is too old - 2.7 or higher required.")
# 	print("Python version is %s" % sys.version)
# 	sys.exit(0)

# parser = argparse.ArgumentParser(description='Parse pex html reports')
# parser.add_argument('pexReportName', metavar='FILE', type=str, help='Path to text filen containing stack')
# parser.add_argument('-mut', metavar='string', type=str, default='method under test', help='name of method under test with param types for example: BBCode.ToHtml(String)' )


# args = parser.parse_args
# print args


# def failureStrRep(failure, order):
# 	s = failure.method
# 	s = s[:s.find('(')]
# 	return s + '_' + str(order) + '_' + failure.exception
qGraphLogReport = "logID0EU"
qGraphParamTableReport = "tparamvaluesID0EU"

DataStructuresLogReport = "logID0EU"
DataStructuresParamTableReport ="tparamvaluesID0EU"

if os.environ['HOMEPATH'] != None and os.environ['HOMEPATH'].find('\\Users\\astor') !=-1 :
	DataStructuresLogReport = "logID0ER"
	DataStructuresParamTableReport = "tparamvaluesID0ER"


LidgrenLogReport = qGraphLogReport
LidgrenParamTableReport = qGraphParamTableReport


#by default id of html tags are those seen for the datastructure cases
logReportAtt =DataStructuresLogReport
paramTableReportAtt =DataStructuresParamTableReport


def getTestNumber(tag):
	testNumTag = tag.find('span', class_="hint")
	testNum = testNumTag.text.strip("(").strip(")")
	return testNum

path = str(sys.argv[1])
f = open(path  , 'r')
html = f.read()
f.close()  

#exploration = ExplorationStats()
soup = BeautifulSoup(html, 'html.parser')

# get class under test(may be irrelevant code: see lines 116 to 122)
titleName = soup.title.string


if titleName.find("QuickGraph") !=-1 :
	logReportAtt =qGraphLogReport
	paramTableReportAtt =qGraphParamTableReport


elif titleName.find("NetBigInteger") != -1:
	logReportAtt =LidgrenLogReport
	paramTableReportAtt =LidgrenParamTableReport


begPexRep = titleName.index("Pex Report")
#exploration.classUnderTest = titleName[0:begPexRep].strip()
classUnderTest = titleName[0:begPexRep].strip()

#getting exploration statistics
for tag in soup.find_all('div', class_="banner"):
	for s in tag.strings:
		startExplor = s.index("exploration")
		startColon = s.index(":")
		startGenTest = s.index("generated")
		startLeftParen = s.index("(")
		startFailing = s.index("failing")
		#exploration.numOfExplorations = s[startColon+1: startExplor].strip()
		#exploration.numberOfTotalTests = s[s.index(",") + 1:startGenTest].strip()
		#exploration.numberOfFailingTest = s[startLeftParen+1:startFailing].strip()



#find test with pathboundsexceeded and save the test number

setTestNum = set()

# iterate through a list of test
tab = soup.find('table',id="testtableID0EC")
divTestTable = tab.find('div', id=logReportAtt)

testTable = divTestTable.find('table')



# iterate through a list of passing test
for tag in testTable.find_all('div', class_="test"):
	#print tag.strings
	for s in tag.strings:
		if s.find("pathboundsexceeded") != -1:
			setTestNum.add(getTestNumber(tag))

# iterate through a list of failing test
for tag in testTable.find_all('div', class_="testfailure"):
	#print tag.text
	for s in tag.strings:
		if s.find("pathboundsexceeded") != -1:
			setTestNum.add(getTestNumber(tag))




t = soup.find('table',id="testtableID0EC") # outermost table containing all relevant tables
paramTable = t.find('table', id=paramTableReportAtt) # table containing parameter values
if paramTable is None:
	print "Pex Done Generating Tests"
	print "No passing or failing inputs were generated"
	sys.exit(0)
paramTable.find('tr').extract() # remove first row since it doesnt contain information relevant to our purposes

entryToPrint = ""
tr = paramTable.find('tr') # header 
first = True
begin = -1
end = -2
result = -3
pos = 0

for th in tr.find_all('th'):
	
	entryToPrint = entryToPrint+ ", " + th.text.strip().replace("\n", " ")
		
	if th.text.find("$input_") != -1 and first:
		begin = pos
		first = False
		end = begin
	elif th.text.find("$") != -1:
		end = pos

	elif th.text.find("Summary/Exception") != -1:
		result = pos
	pos +=1

print entryToPrint
entryToPrint = ""

#print "values begin: "+str(begin) + " end "+str(end)
positiveSample = list()

pp = pprint.PrettyPrinter(indent=4)

debugg =1 

for trOdd in paramTable.find_all('tr', class_ = 'odd'):
	index =0 
	features = list()
	oddBoundsExcedded= True
	for td in trOdd.find_all('td'): # iterating horizontally
		if index == 0 and td.text in setTestNum:
			#print "odd num " +td.text
			oddBoundsExcedded =False
		
		elif((index >= begin and index <= end)):
			if(td.text.find("int.MinValue") !=- 1):
				features.append("-2147483648")

			elif(td.text.find("int.MaxValue") !=- 1):
				features.append("2147483647")
			elif(td.text.find(" (0x20)")!= -1):
				features.append(td.text.replace(" (0x20)", ""))
			else:
				features.append(td.text.strip().replace("\n", " "))
			
		elif index == result: # this case is only true in the final loop iteration
			features.append("true")
		entryToPrint = entryToPrint+ ", " + td.text.strip().replace("\n", " ")
		index +=1
	
	if (entryToPrint.find("Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException") == -1 and  entryToPrint.find("MinimizationRequestException") == -1 
		and entryToPrint.find("Predicate does not return true for all indices") == -1 and  (re.search('(.*)(at segment index)(.*)(needs object of type)(.*)',entryToPrint,re.DOTALL) is None) 
		and entryToPrint.find("ExplorableObjectNotAvailableException") ==-1 and entryToPrint.find("at segment index 0 needs object of type") == -1 and entryToPrint.find("PexRetryException") ==-1 and oddBoundsExcedded):
		#print "#########odd " +str(features)
		#print "Why here odd"
		#print entryToPrint
		positiveSample.append(features)

	# print entryToPrint
	entryToPrint = ""

evenDoesNotExceddedBounds= True
for trEven in paramTable.find_all('tr', class_ = 'even'):
	index =0 
	features = list()
	evenDoesNotExceddedBounds= True
	for td in trEven.find_all('td'):
		if index == 0 and td.text in setTestNum:
			#print "even num " + td.text
			evenDoesNotExceddedBounds = False

		elif((index >= begin and index <= end)):
			if(td.text.find("int.MinValue") !=- 1):
				features.append("-2147483648")

			elif(td.text.find("int.MaxValue") !=- 1):
				features.append("2147483647")
			elif(td.text.find(" (0x20)")!= -1):
				features.append(td.text.replace(" (0x20)", ""))
			else:
				features.append(td.text.strip().replace("\n", " "))

		elif index == result: # this case is only true in final loop iteration
			features.append("true")
		entryToPrint = entryToPrint+ ", " + td.text.strip().replace("\n", " ")
		index +=1

	if (entryToPrint.find("Microsoft.Pex.Framework.Exceptions.PexAssumeFailedException") == -1 and  entryToPrint.find("MinimizationRequestException") == -1 
		and  (re.search('(.*)(at segment index)(.*)(needs object of type)(.*)',entryToPrint,re.DOTALL) is None) 
		and entryToPrint.find("Predicate does not return true for all indices") == -1 and entryToPrint.find("at segment index 0 needs object of type") == -1 
		and entryToPrint.find("ExplorableObjectNotAvailableException") ==-1 and entryToPrint.find("PexRetryException") ==-1 and evenDoesNotExceddedBounds):
		#print "########even " +str(features)
		#print "Why here even"
		#print entryToPrint
		positiveSample.append(features)
	#positiveSample.append(features)
	# print entryToPrint
	entryToPrint = ""

done = True

negativeSample = list()
for trError in paramTable.find_all('tr', class_ = 'error'):
	index =0 
	features = list()
	check = True
	errorDoesNotExceedBounds= True
	for td in trError.find_all('td'):
		if index == 0 and td.text in setTestNum:
			#print "num " + td.text
			errorDoesNotExceedBounds = False
		elif((index >= begin and index <= end) ):
			if(td.text.find("int.MinValue") !=- 1):
				features.append("-2147483648")

			elif(td.text.find("int.MaxValue") !=- 1):
				features.append("2147483647")
			elif(td.text.find(" (0x20)")!= -1):
				features.append(td.text.replace(" (0x20)", ""))
			else:
				features.append(td.text.strip().replace("\n", " "))

		elif index == result:
			features.append("false")
		index +=1
		#entryToPrint = entryToPrint+ ", " + ' '.join([ tdx.strip() for tdx in td.text.strip()]) #replace("\n", " ")
		entryToPrint = entryToPrint+ ", " + td.text.strip().replace("\n", " ")
	if errorDoesNotExceedBounds and entryToPrint.find("ExplorableObjectNotAvailableException") ==-1:
		done = False
		negativeSample.append(features)

	#print entryToPrint	
	entryToPrint = ""

print "Pex Done Generating Tests"
if done == True:
	with open("..\..\..\..\pre.data", 'a+') as myfile:
		wr = csv.writer(myfile, quoting=csv.QUOTE_NONE, escapechar = '\\')
		for x in positiveSample:
			wr.writerow(x)
	
	print "Pex Found No Error"
	print "Passing Test: " + str(len(positiveSample)) 

else:
	with open("..\..\..\..\pre.data", 'a+') as myfile:
		wr = csv.writer(myfile, quoting=csv.QUOTE_NONE, escapechar = '\\')
		for x in positiveSample:
			wr.writerow(x)
		for y in negativeSample:
			wr.writerow(y)

	print "Passing Test: " + str(len(positiveSample))
	print "Failing Test: " + str(len(negativeSample))