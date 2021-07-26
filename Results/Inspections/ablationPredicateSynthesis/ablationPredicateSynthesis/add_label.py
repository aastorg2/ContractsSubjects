from argparse import ArgumentParser as AP
import re

def add_label(filename):
    i_file = open(filename)
    lines = i_file.readlines()
    i_file.close()

    i_file = open(filename, 'w')
    for line_idx in range(len(lines)):
        line = lines[line_idx]
        if "smt check:" in line:
            line = "Truly Safe: \n\n" + line
        i_file.write(line)
    i_file.close()

if __name__ == "__main__":
    argument_parser = AP()
    argument_parser.add_argument('--file', '-f', type=str, nargs=1, required=True)

    args = argument_parser.parse_args()

    i_file = args.file[0]

    add_label(i_file)