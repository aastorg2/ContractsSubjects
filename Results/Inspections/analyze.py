

def AnalyzeInspections(fileName):
    disjuncs = 0
    numRefined = 0
    numContracts = 0
    alternate = 0
    truly = 0
    disjunctiveContracts = []
    conjunctiveContracts = []
    missedDisjunctiveContracts = []
    missedConjunctiveContracts = []
    disjuncForPex = False
    disjuncForAlt = False
    trulyDisjunc = False
    passedk0 = False
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
            print(contract)
            print(disjuncForPex)
            print(lines[lineIndex])
        if "Disjunctive (Alternate Semantics)" in lines[lineIndex]:
            if "True" in lines[lineIndex]:
                disjuncForAlt = True
                alternate += 1
            else:
                disjuncForAlt = False
        if "Disjunctive (Truly)" in lines[lineIndex]:
            if "True" in lines[lineIndex]:
                trulyDisjunc = True
                truly += 1
            else:
                trulyDisjunc = False
        if "k == 2" in lines[lineIndex]:
            if disjuncForPex and trulyDisjunc:
                disjunctiveContracts.append(contract)
            elif not disjuncForPex and not trulyDisjunc:
                conjunctiveContracts.append(contract)
            elif disjuncForPex and not trulyDisjunc:
                missedConjunctiveContracts.append(contract)
            elif not disjuncForPex and trulyDisjunc:
                missedDisjunctiveContracts.append(contract)
            while not "simplified postcondition:" in lines[lineIndex]:
                lineIndex += 1
            disjuncs += lines[lineIndex].count("||")
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
