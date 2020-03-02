import subprocess
import sys
import re
import os
import time
import argparse
import collections
import pprint
import csv
import json
import time
import shutil
import io
from lxml import etree

def parseAllStats():
    pathToRandoopOutput = os.path.abspath("randoop_output")
    runs = ["randoop_output/" + fileName for fileName in os.listdir(pathToRandoopOutput)]
    runs = sorted(runs, key=sortByTime)
    ##remove all runs except for most recent one
    ###don't forget to sort by month
    for fileName in range(0, len(runs) - 1):
        shutil.rmtree(os.path.abspath(runs[fileName]), ignore_errors=True)

    run = ["randoop_output/" + fileName for fileName in os.listdir(pathToRandoopOutput)][0]
    parse(run)

def sortByTime(x):
    ordinals = [word for word in x.split("_") if containsDigit(word)]
  
    return getTime(ordinals)

def containsDigit(word):
    return len([int(char) for char in word if char.isdigit()]) > 0

def getTime(ordinals):
    totalTimeInSeconds = 0
    for ordinal in ordinals:
        if ordinal.isdigit():
            if len(ordinal) < 4:
                totalTimeInSeconds += int(ordinal) * 86400 #days
        elif "h" in ordinal:
            totalTimeInSeconds += getNumber(ordinal) * 3600 #hours
        elif "m" in ordinal:
            totalTimeInSeconds += getNumber(ordinal) * 60 # minutes
        elif "s" in ordinal:
            totalTimeInSeconds += getNumber(ordinal) # seconds
    return totalTimeInSeconds
      
      
def getNumber(string):
    num = "".join([char for char in string if char.isdigit()])
    return int(num)

def parse(run):
    path = os.path.abspath(run)
    allStatsPath = path + "/allstats.txt"

    allstats = open(allStatsPath, 'r')
    lines = allstats.readlines()
    allstats.close()

    lineIndex = 0
    while lineIndex < len(lines):
        if "PUT_" in lines[lineIndex]:
            index_put = lines[lineIndex].index("PUT_")
            index_paren = lines[lineIndex].index('(')

            put = lines[lineIndex][index_put:index_paren]

            equals = ""
            for char in put:
                equals += "="
            print(equals)
            print(put)
            print(equals)

            while not "SUCCEEDED" in lines[lineIndex]:
                lineIndex += 1
            
            succeeded = [int(char) for char in lines[lineIndex].split() if char.isdigit()][0]
            
            print(f"\t+NUMBER OF TESTS GENERATED: {succeeded}")
            
            while not "Test execution statistics." in lines[lineIndex]:
                lineIndex += 1
            lineIndex += 1

            passes = 0
            while "PexAssumeFailedException" in lines[lineIndex] or "normal" in lines[lineIndex]:
                passes += [int(char) for char in lines[lineIndex].split() if char.isdigit()][0]
                lineIndex += 1

            print(f"\t+TRULY SAFE: {succeeded == passes}", end="\n\n")

        lineIndex += 1

def runRandoop(randoop, problem):
    commandToRun = getRandoopRunCommand(randoop, problem)
    output = runCommand(commandToRun)

def getRandoopRunCommand(randoopExe, problem):
        TIMELIMIT = "100"
        pathToExecutable = os.path.abspath(randoopExe)
        pathToArgument = os.path.abspath(problem)
        runCommand = pathToExecutable + " " + pathToArgument + f" /noexplorer /timelimit:{TIMELIMIT}"
        return runCommand

def runCommand(args):
    try:
        executionOutput = ""
        executionRun = subprocess.Popen(args, stdout = subprocess.PIPE, stderr = subprocess.PIPE)
        for line in executionRun.stdout:
            executionOutput += os.linesep + str(line.rstrip())
        executionRun.stdout.close()
        return executionOutput
    except OSError as e:
        print('OSError > ', e.errno)
        print('OSError > ', e.strerror)
        print('OSError > ', e.filename)       
        raise OSError
    except:
        print('Error > ', sys.exc_info()[0])
        raise OSError

if __name__ == "__main__":
    parser = argparse.ArgumentParser()

    parser.add_argument("--assembly", "-a", type=str, required=True)
    parser.add_argument("--randoop_path", "-r", type=str, required=True)

    args = parser.parse_args()

    assembly = args.assembly
    randoop = args.randoop_path    

    runRandoop(randoop, assembly)
    parseAllStats()