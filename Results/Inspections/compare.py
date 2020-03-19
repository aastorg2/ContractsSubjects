import argparse
import os


# Functino that read the lines of two inspection files and returns them as lists of strings
def read_inspections(inspections: "list")-> "list":
 # The scanned inspections to return
 scans = list()
 # Reads the inspections and inserts them into a list
 for inspection in inspections:
  abs_path_to_file = os.path.abspath(inspection)
  file = open(abs_path_to_file)
  lines = "".join(file.readlines())
  scans.append(lines)
  file.close()
 return scans


# Function that compares two inspections files and print which cases
# where the post conditions differ to the standard out
def compare_inspections(scanned_inspections: "list")-> "None":
 # The contracts to compare
 contracts = dict()
 # The contracts that is different in terms of their postcondition
 contracts_that_differ = list()
 # For each contract split it into cases
 for inspection in scanned_inspections:
  # Split inspection into list of contracts and omit the problem description
  contracts_to_compare = inspection.split("---------------------")[1:]
  for contract in contracts_to_compare:
   contract_name = contract.split("\n")[1]
   postcondition = get_postcondition(contract)
   if not contract_name in contracts:
    contracts[contract_name] = postcondition
   elif not postcondition == contracts[contract_name]:
    contracts_that_differ.append(contract_name)
 # Print out every contracts that is different in terms of their postcondition
 print("CONTRACTS THAT ARE DIFFERENT IN TERMS OF THEIR POSTCONDITION:")
 if len(contracts_that_differ) > 0:
  for contract in contracts_that_differ:
   print(f"\t{contract}")


# Function that extracts the postcondition from a contract
def get_postcondition(contract: "str")-> "str":
 # The postcondition
 postconditon: str
 for line in contract.split("\n"):
  if "CNF" in line:
   postconditon = line
 return postconditon


# Main Method
if __name__ == "__main__":
 # Instantiate an argument parser
 parser = argparse.ArgumentParser()
 # Add a named argument
 parser.add_argument("-inspections", type=str, nargs=2, required=True)
 # Parse the arguments passed in from command line
 args = parser.parse_args()
 # Get the value of the argument from the namespace (should be a list of strings)
 inspections = args.inspections
 # Read the lines of the two inspections
 scanned_inspections = read_inspections(inspections)
 # Compare the two inspections
 compare_inspections(scanned_inspections)