import argparse, os
TOREPLACE = "[PexMethod]"
REPLACEMENT = "[PexMethod(MaxRuns=100)]"


if __name__ == "__main__" :
    parser = argparse.ArgumentParser()

    parser.add_argument("--solution", "-s", type=str, required=True)
    args = parser.parse_args()

    solution = args.solution

    path = os.path.abspath(solution)
    file = open(path, 'r')
    lines = file.readlines()
    file.close()

    text = "".join(lines)
    text = text.replace(REPLACEMENT,TOREPLACE)
    #text = text.replace(TOREPLACE, REPLACEMENT)

    file = open(path, 'w')
    file.write(text)
    file.close()