

def PrepInspections(files):
    for fileName in files:
        initInspection = open(fileName, 'r')
        lines = initInspection.readlines()
        initInspection.close()

        newFileName = "new_" + fileName             # change this to whatever you wish
        readyInspection = open(newFileName, 'w')
        for line in lines:
            if "PUT_" in line:
                line += """
Disjunctive (PexObserve):
Disjunctive (Alternate Semantics):
Disjunctive (Truly):
"""
            elif "k == " in line:
                line += """
learned postcondition:

simplified postcondition:

predicates:
"""
            readyInspection.write(line)
        readyInspection.close()

# def FillInspections(files):
#     for fileName in files:
#         result = open(fileName, 'r')
#         resultLines = result.readlines()
#         result.close()
#         fileName.replace("results", "ahmad_inspections")
#         inspection = open(fileName, 'r')
#         inspectionLines = inspection.readlines()
#         inspection.close()
#         readyInspection = open(fileName, 'w')
#         postConditions = []
#         for index in range(0, len(resultLines)):
#             resultLine = resultLines[index]
#             if 'simplified post k ==' in resultLine or 'simple' in resultLine:
#             if 'simplified post k ==' in resultLine or 'simple' in resultLine:
                
#                 line += """
# Disjunctive (PexObserve):
# Disjunctive (Alternate Semantics):
# Disjunctive (Truly):
# """
#             elif "k == " in line:
#                 line += """
# learned postcondition:

# simplified postcondition:

# predicates:
# """
#             readyInspection.write(line)
#         readyInspection.close()

if __name__ == "__main__":
    import argparse, sys
    parser = argparse.ArgumentParser()                                               

    parser.add_argument("--inspections", "-i", type=str, required=True, nargs=argparse.ONE_OR_MORE)
    args = parser.parse_args()

    inspectionResults = args.inspections
    if inspectionResults == None:
        print("command must be used with --inspections")
        sys.exit(-1)
    PrepInspections(args.inspections)
