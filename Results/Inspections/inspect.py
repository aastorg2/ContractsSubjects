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

def ChangeInspection(files):
    agreement = open(files[1], 'r')
    newLines = agreement.readlines()
    agreement.close()

    updatedInspection = open(files[0], 'w')
    for lineIndex in range(0, len(newLines)):
        updatedInspection.write(newLines[lineIndex])
    updatedInspection.close()


def PrepareInspections(fileName, subject):
    import re

    initInspection = open(fileName, 'r')
    lines = initInspection.readlines()
    initInspection.close()
    spliceIndex = fileName.index("results")
    fileName = fileName[spliceIndex:]
    newFileName = "inspected_" + fileName
    readyInspection = open(newFileName, 'w')
    header = lines[0]
    subject[SUBJECT] = header
    readyInspection.write(header)
    predicate = "None"
    predicateRight = "None"
    predicateLeft = "None"
    currentContract = None
    for lineIndex in range(1, len(lines)):
        line = ""
        if "PUT: " in lines[lineIndex]:
            splitIndex = lines[lineIndex].index(":") + 1
            contract = lines[lineIndex][splitIndex:].lstrip()
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
        if len(re.findall("Not[(]k[0-2] -> k[0-2][)][?]", lines[lineIndex])) > 0:
            valid = "False"
            if "unsat" in lines[lineIndex]:
                valid = "True"
            start = lines[lineIndex].rindex("(") + 1
            end = lines[lineIndex].rindex(")")
            line = f"""
{lines[lineIndex][start:end]}: {valid}
"""
            currentContract.cases += line
            if "k2" in line:
                subject[currentContract.name] = currentContract

        readyInspection.write(line)
    readyInspection.close()

def CompleteInspections(fileName, pexSubject, alternateSubject):
    fileName = fileName.replace("..\\Runs\\", "")
    biggerSubject = pexSubject if len(pexSubject) >= len(alternateSubject) else alternateSubject
    smallerSubject = alternateSubject if len(alternateSubject) <= len(pexSubject) else pexSubject
    for contract in smallerSubject:
        if contract is SUBJECT:
            continue
        if contract in biggerSubject:
            smallerContractDisjuncCount = smallerSubject[contract].bestRefine.count("||")  # If another contract is added this conditional will not work
            biggerContractDisjuncCount = biggerSubject[contract].bestRefine.count("||") # so find a adiffernt solution after this implement
            if (smallerContractDisjuncCount > biggerContractDisjuncCount):
                biggerSubject[contract] = smallerSubject[contract]
    newFileName = "ahmad_inspected_" + fileName
    readyInspection = open(newFileName, 'w')
    for contract in biggerSubject:
        readyInspection.write(biggerSubject[contract].__str__())
    readyInspection.close()

if __name__ == "__main__":
    import argparse, sys
    parser = argparse.ArgumentParser()                                               

    parser.add_argument("--file", "-f", type=str, required=False)
    args = parser.parse_args()

    results = args.file
    if results == None:
        sys.exit(-1)
    subject = {} # Will be filled with contracts after method call
    PrepareInspections(results, subject)