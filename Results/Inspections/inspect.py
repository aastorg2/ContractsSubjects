#Still need to label entries if alternate arguement is passed
SUBJECT = "SUBJECT"

class Contract:
    def __init__(self, name):
        self.name = name
        self.disjunctivity = ""
        self.cases = ""
        self.bestRefine = ""

    def __str__(self):
        return self.disjunctivity + self.cases

def getPath(file):
    import os
    return os.path.abspath(file)

def NewInspect(fileName, contracts, ovveride):
    import re
    path = getPath(fileName)
    initInspection = open(path, 'r')
    lines = initInspection.readlines()
    initInspection.close()
    header = lines[0]
    if not ovveride:
        spliceIndex = fileName.index("results")
        fileName = fileName[spliceIndex:]
        #newFileName = "CurrentInspections\inspected_" + fileName
        newFileName = "inspected_" + fileName
        readyInspection = open(newFileName, 'w')
        readyInspection.write(header)
    contracts[SUBJECT] = header
    predicate = "None"
    predicateRight = "None"
    predicateLeft = "None"
    currentContract = None
    resultSeen = False
    predicates = []
    rounds = ""
    total_rounds = 0
    total_pextime = 0
    total_learntime = 0
    for lineIndex in range(1, len(lines)):
        line = ""
        if "PUT: " in lines[lineIndex]:
            splitIndex = lines[lineIndex].index(":") + 1
            contract = lines[lineIndex][splitIndex:].lstrip().replace("\n", "")
            currentContract = Contract(contract)
            
            line = f"""
---------------------
{contract}
Disjunctive (PexChoose):
Disjunctive (Alternate Semantics):
Disjunctive (Truly):

Label:

Analysis:
"""
            currentContract.disjunctivity = line
        if "Final Tree ====" in lines[lineIndex]:
            predicates = []
            while lineIndex < len(lines) and not "===== Final Result" in lines[lineIndex]:
                if "Predicate" in lines[lineIndex]:
                    predicates.append(lines[lineIndex])
                lineIndex += 1
        if "rounds" in lines[lineIndex] and not "max" in lines[lineIndex]:
                    #predicate = "None"
                    #predicateRight = "None"
                    #predicateLeft = "None"
                    splitIndex = lines[lineIndex].index(":") + 1
                    rounds = lines[lineIndex][splitIndex:].strip().replace("\n", "")
                    total_rounds += int(rounds)
        #currentContract.cases += line
        if "postcondition" in lines[lineIndex]:
            line = f"""
learned postcondition: {lines[lineIndex + 1]}"""
            currentContract.cases += line
        if "simplified post" in lines[lineIndex]:
            predicateStrings = "\n".join(predicates)
            line = f"""
simplified postcondition: {lines[lineIndex + 1]}
{predicateStrings}
rounds: {rounds}
"""     
            currentContract.cases += line
        if "pex time:" in lines[lineIndex]:
            splitIndex = lines[lineIndex].index(":") + 1
            pextime = lines[lineIndex][splitIndex:].strip().replace("\n", "")
            total_pextime += float(pextime)
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
        if "learn time:" in lines[lineIndex]:
            splitIndex = lines[lineIndex].index(":") + 1
            learntime = lines[lineIndex][splitIndex:].strip().replace("\n", "")
            total_learntime += float(learntime)
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
        if "Samples" in lines[lineIndex]:
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
            contracts[currentContract.name] = currentContract
#         if len(re.findall("Not[(]k[0-2] -> k[0-2][)][?]", lines[lineIndex])) > 0:
#             valid = "False"
#             if "unsat" in lines[lineIndex]:
#                 valid = "True"
#             start = lines[lineIndex].rindex("(") + 1
#             end = lines[lineIndex].rindex(")")
#             line = f"""
# {lines[lineIndex][start:end]}: {valid}
# """
#             currentContract.cases += line
#             if "k2" in line:
#                 contracts[currentContract.name] = currentContract

        if not ovveride: readyInspection.write(line)
    line = f"""
======================
Average Rounds: {total_rounds / (len(contracts) - 1)}

Average Pex Time: {total_pextime / (len(contracts) - 1)}

Average Learn Time: {total_learntime / (len(contracts) - 1)}
"""
    readyInspection.write(line)
    if not ovveride: readyInspection.close()

def Inspect(fileName, contracts, ovveride):
    import re
    path = getPath(fileName)
    initInspection = open(path, 'r')
    lines = initInspection.readlines()
    initInspection.close()
    header = lines[0]
    if not ovveride:
        spliceIndex = fileName.index("results")
        fileName = fileName[spliceIndex:]
        newFileName = "CurrentInspections\inspected_" + fileName
        readyInspection = open(newFileName, 'w')
        readyInspection.write(header)
    contracts[SUBJECT] = header
    predicate = "None"
    predicateRight = "None"
    predicateLeft = "None"
    currentContract = None
    for lineIndex in range(1, len(lines)):
        line = ""
        if "PUT: " in lines[lineIndex]:
            splitIndex = lines[lineIndex].index(":") + 1
            contract = lines[lineIndex][splitIndex:].lstrip().replace("\n", "")
            currentContract = Contract(contract)
            
            line = f"""
---------------------
{contract}
Disjunctive (PexChoose):
Disjunctive (Alternate Semantics):
Disjunctive (Truly):
"""
            currentContract.disjunctivity = line
        if "Case: k ==" in lines[lineIndex]:
            currentCase = lines[lineIndex].index("==") + 3
            case = lines[lineIndex][currentCase:]
            while lineIndex < len(lines) and not "===== Final Result" in lines[lineIndex]:
                if "Round" in lines[lineIndex]:
                    predicate = "None"
                    predicateRight = "None"
                    predicateLeft = "None"
                if "Predicate: root Left" in lines[lineIndex]:
                    splitIndex = lines[lineIndex].rindex(":") + 1
                    predicateLeft = lines[lineIndex][splitIndex:].lstrip().replace("\n", "")
                if "Predicate: root Right" in lines[lineIndex]:
                    splitIndex = lines[lineIndex].rindex(":") + 1
                    predicateRight = lines[lineIndex][splitIndex:].lstrip().replace("\n", "")
                if "Predicate: root for k =" in lines[lineIndex]:
                    splitIndex = lines[lineIndex].rindex(":") + 1
                    predicate = lines[lineIndex][splitIndex:].lstrip().replace("\n", "")
                lineIndex += 1
            if lineIndex >= len(lines):
                break
            line = f"""
======
k == {case}"""
            currentContract.cases += line
        if "postcondition k ==" in lines[lineIndex]:
            line = f"""
learned postcondition: {lines[lineIndex + 1]}"""
            currentContract.cases += line
        if "simplified post k ==" in lines[lineIndex]:
            line = f"""
simplified postcondition: {lines[lineIndex + 1]}
predicate: {predicate}

predicate right: {predicateRight}

predicate left: {predicateLeft}

Any:

L:

SubL:
"""
            currentContract.cases += line
            if "2" in lines[lineIndex]:
                currentContract.bestRefine = lines[lineIndex + 1]
        if "pex time:" in lines[lineIndex]:
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
        if "learn time:" in lines[lineIndex]:
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
        if "Samples" in lines[lineIndex]:
            line = f"\n{lines[lineIndex]}"
            currentContract.cases += line
            contracts[currentContract.name] = currentContract
#         if len(re.findall("Not[(]k[0-2] -> k[0-2][)][?]", lines[lineIndex])) > 0:
#             valid = "False"
#             if "unsat" in lines[lineIndex]:
#                 valid = "True"
#             start = lines[lineIndex].rindex("(") + 1
#             end = lines[lineIndex].rindex(")")
#             line = f"""
# {lines[lineIndex][start:end]}: {valid}
# """
#             currentContract.cases += line
#             if "k2" in line:
#                 contracts[currentContract.name] = currentContract

        if not ovveride: readyInspection.write(line)
    if not ovveride: readyInspection.close()

def OverrideInspections(fileName, oldSubject, newSubject):
    spliceIndex = fileName.index("results")
    fileName = fileName[spliceIndex:]
    newFileName = "CurrentInspections\inspected_" + fileName
    for contract in newSubject:
        if contract is SUBJECT:
            continue
        elif contract in oldSubject:
            oldSubject[contract] = newSubject[contract]
    readyInspection = open(newFileName, 'w')
    for contract in oldSubject:
        readyInspection.write(oldSubject[contract].__str__())    
    readyInspection.close()

if __name__ == "__main__":
    import argparse
    parser = argparse.ArgumentParser()                                               

    parser.add_argument("--mode", "-m", type=str, required=True)
    parser.add_argument("--regression-results", "-r", type=str, required=True)
    parser.add_argument("--old-regression-results", "-o", type=str, required=False)
    args = parser.parse_args()

    mode = args.mode
    regressionResults = args.regression_results
    oldRegressionResults = args.old_regression_results
    contracts = {}
    if mode == "New" or mode == "Override":
        NewInspect(regressionResults, contracts, False)
    if mode == "Override" and not oldRegressionResults is None:
        oldContracts = {}
        NewInspect(oldRegressionResults, oldContracts, True)
        OverrideInspections(oldRegressionResults, oldContracts, contracts)