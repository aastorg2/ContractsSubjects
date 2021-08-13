from argparse import ArgumentParser as AP
import re

def get_label_info(filename):
    i_file = open(filename)
    lines = i_file.readlines()
    i_file.close()

    #Dicionary to store PUTs and map their smt results
    smt_dict = {"Unknown" : [], "Precis" : [], "Other" : [], "Equivalent" : []}
    #regex string for isolating smt check from string
    pattern = r'[\s]*smt check: ([\w]+)'
    PUT = ""
    count = 0
    for line in lines:
        if "PUT_" in line:
            PUT = line
        elif "smt check:" in line:
            key = re.findall(pattern, line)[0]
            smt_dict[key].append(PUT.strip())
        count
    return smt_dict

def print_info(info):
    out = ""
    for label in info:
        out += f"""
{label}({len(info[label])})
{info[label]}

"""
    print(out)

if __name__ == "__main__":
    argument_parser = AP()
    argument_parser.add_argument('--file', '-f', type=str, nargs=1, required=True)

    args = argument_parser.parse_args()

    i_file = args.file[0]

    label_info = get_label_info(i_file)
    print_info(label_info)