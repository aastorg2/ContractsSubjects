

def AnalyzeInspections(fileName):
    import re

    numContracts = 0
    alternate = 0
    truly = 0
    disjunctiveContracts = []
    conjunctiveContracts = []
    missedDisjunctiveContracts = []
    missedConjunctiveContracts = []
    disjuncForPex = False
    contract = ""
    inspection = open(fileName, 'r')
    lines = inspection.readlines()
    inspection.close()
    for lineIndex in range(0, len(lines)):
        if "Contract" in lines[lineIndex]:
            contract = lines[lineIndex].replace("\n", "")
            numContracts += 1
        if "Disjunctive (PexChoose)" in lines[lineIndex]:
            if "True" in lines[lineIndex]:
                disjuncForPex = True
            else:
                disjuncForPex = False
        if "Disjunctive (Alternate Semantics)" in lines[lineIndex]:
            if "True" in lines[lineIndex]:
                alternate += 1
        if "Disjunctive (Truly)" in lines[lineIndex]:
            if "True" in lines[lineIndex]:
                truly += 1
                if disjuncForPex:
                    idxCopy = lineIndex
                    while idxCopy < len(lines) and not "k == 2" in lines[idxCopy]:
                        idxCopy += 1
                    while idxCopy < len(lines) and not "Any" in lines[idxCopy]:
                        idxCopy += 1
                    if len(re.findall("[p|P]ass", lines[idxCopy])) > 0:
                        disjunctiveContracts.append(contract)
                    else:
                        while idxCopy < len(lines) and not "k == 2" in lines[idxCopy]:
                            idxCopy += 1
                        while idxCopy < len(lines) and not "Any" in lines[idxCopy]:
                            idxCopy += 1
                        if len(re.findall("[p|P]ass", lines[idxCopy])) > 0:
                            disjunctiveContracts.append(contract)
                        else:
                            missedDisjunctiveContracts.append(contract)
                else:
                    idxCopy = lineIndex
                    while idxCopy < len(lines) and not "k == 2" in lines[idxCopy]:
                        idxCopy += 1
                    while idxCopy < len(lines) and not "Any" in lines[idxCopy]:
                        idxCopy += 1
                    if len(re.findall("[r|R]eject", lines[idxCopy])) > 0:
                        missedDisjunctiveContracts.append(contract)
                    else:
                        pprint(f"MISLABELED {contract}")
                        print("k == 2")
                        print(lines[idxCopy])
            else:
                if disjuncForPex:
                    idxCopy = lineIndex
                    while idxCopy < len(lines) and not "k == 2" in lines[idxCopy]:
                        idxCopy += 1
                    while idxCopy < len(lines) and not "Any" in lines[idxCopy]:
                        idxCopy += 1
                    if len(re.findall("[p|P]ass", lines[idxCopy])) > 0:
                        missedConjunctiveContracts.append(contract)
                    else:
                        print(f"MISLABELED {contract}")
                        print("k == 2")
                        print(lines[idxCopy])
                else:
                    idxCopy = lineIndex
                    while idxCopy < len(lines) and not "k == 0" in lines[idxCopy]:
                        idxCopy += 1
                    while idxCopy < len(lines) and not "Any" in lines[idxCopy]:
                        idxCopy += 1
                    if len(re.findall("[p|P]ass", lines[idxCopy])) > 0:
                        conjunctiveContracts.append(contract)
                    else:
                        missedConjunctiveContracts.append(contract)
    print("""=======
RESULTS
=======""")
    print(f"Total Contracts: {numContracts}")
    print(f"Number of truly disjunctive contracts: {truly}")
    print(f"Number of correct disjunctive contracts found using PexChoose: {len(disjunctiveContracts)}/{truly}")
    print(f"Number of correct disjunctive contracts found using Alternate Semantics: {alternate}/{truly}")
    print(f"Number of truly conjunctive contracts found (PexChoose): {len(conjunctiveContracts)}/{abs(numContracts - truly)}")
    # print(f"Ratio of most disjunctive formulas found using PexChoose to total disjunctives found: {numRefined}:{truly}")
    print(f"Correct disjunctive contracts found with PexChoose:")
    for contract in disjunctiveContracts:
        print(f"\t{contract}")
    print(f"Correct disjunctive contracts missed with PexChoose:")
    for contract in missedDisjunctiveContracts:
        print(f"\t{contract}")
    print(f"correct Conjunctive contracts found with PexChoose:")
    for contract in conjunctiveContracts:
        print(f"\t{contract}")
    print(f"Correct conjunctive contracts missed with PexChoose:")
    for contract in missedConjunctiveContracts:
        print(f"\t{contract}")


if __name__ == "__main__":
    import argparse, sys
    parser = argparse.ArgumentParser()                                               

    parser.add_argument("--file", "-f", type=str, required=True)
    args = parser.parse_args()

    inspectionResults = args.file
    if inspectionResults == None:
        print("command must be used with --file")
        sys.exit(-1)
    AnalyzeInspections(args.file)
