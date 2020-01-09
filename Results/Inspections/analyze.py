

def AnalyzeInspections(fileName):
    disjuncs = 0
    numRefined = 0
    numContracts = 0
    pex = 0
    alternate = 0
    truly = 0
    contracts = {}
    conjunctiveContracts = []
    disjuncForPex = False
    disjuncForAlt = False
    trulyDisjunc = False
    contract = ""
    inspection = open(fileName, 'r')
    lines = inspection.readlines()
    inspection.close()
    for lineIndex in range(0, len(lines)):
        if "Contract" in lines[lineIndex]:
            contract = lines[lineIndex].replace("\n", "")
            contracts[contract] = False
            numContracts += 1
        if "Disjunctive (PexChoose): True" in lines[lineIndex]:
            disjuncForPex = True
            pex += 1
        if "Disjunctive (PexChoose): False" in lines[lineIndex]:
            disjuncForPex = False
        if "Disjunctive (Alternate Semantics): True" in lines[lineIndex]:
            disjuncForAlt = True
            alternate += 1
        if "Disjunctive (Alternate Semantics): False" in lines[lineIndex]:
            disjuncForAlt = False
        if "Disjunctive (Truly): True" in lines[lineIndex]:
            trulyDisjunc = True
            truly += 1
            contracts[contract] = not disjuncForPex and disjuncForAlt
        elif "Disjunctive (Truly): False" in lines[lineIndex]:
            trulyDisjunc = False
            conjunctiveContracts.append(contract)
        # if "k == 0" in lines[lineIndex]:
        #     passed = False
        #     if "Any: Pass" in lines[lineIndex + 8]: # find a better solution
        #         passed = True
        #         numRefined += 1
        # if not passed and "k == 1" in lines[lineIndex]:
        #     if "Any: Pass" in lines[lineIndex + 8]:
        #         passed = True
        #         numRefined += 1
        if "k == 2" in lines[lineIndex]:
            if trulyDisjunc and "Any: Pass" in lines[lineIndex + 8]: # find a better solution for this
                numRefined += 1
            while not "simplified postcondition:" in lines[lineIndex]:
                lineIndex += 1
            disjuncs += lines[lineIndex].count("||")
    print("""=======
RESULTS
=======""")
    print(f"Total Contracts: {numContracts}")
    print(f"Number of truly disjunctive contracts: {truly}")
    print(f"Number of correct disjunctive contracts found using PexChoose: {pex}/{truly}")
    print(f"Number of correct disjunctive contracts found using Alternate Semantics: {alternate}/{truly}")
    print(f"Number of correct conjunctive contracts found (PexChoose): {len(conjunctiveContracts)}")
    # print(f"Ratio of most disjunctive formulas found using PexChoose to total disjunctives found: {numRefined}:{truly}")
    print(f"Correct disjunctive contracts found with PexChoose:")
    for contract in contracts:
        if not contracts[contract] and contract not in conjunctiveContracts:
            print(f"\t{contract}")
    print(f"Correct disjunctive contracts missed with PexChoose:")
    for contract in contracts:
        if contracts[contract]:
            print(f"\t{contract}")
    # print(f"Disjunctive contracts found with PexChoose:")
    # for contract in contracts:
    #     if not contracts[contract]:
    #         print(f"\t{contract}")
    print(f"Correct conjunctive contracts found with PexChoose:")
    for contract in conjunctiveContracts:
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
