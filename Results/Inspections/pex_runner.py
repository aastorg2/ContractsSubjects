import subprocess
import sys
import re
import os
import time
import argparse
import collections
import pprint
import csv
import json
import time
import shutil
import io
import platform
#from lxml import etree


# Returns the absolute path to a file or directory
def get_abs_path(path: "str")-> "str":
    return os.path.abspath(path)


# Method that handles setting up pex, rebuilding the solution and running pex
def run(contract_test, solution, assembly)-> "None":
    # Replace all [PexMethod]
    pex_replacement(contract_test)
    # Build solution
    build(solution)
    # Get the contracts
    contracts = get_contracts(contract_test)
    # Run pex
    run_pex(solution, contracts, assembly)


# Method to set up pex config
def pex_replacement(contract_test: "str")-> "None":
    abs_path_to_contract_test = get_abs_path(contract_test)
    # What you wish to replace
    to_replace = "[PexMethod]"
    # What you wish to replace with
    replacement = "[PexMethod(MaxRuns=100)]"
    # Reads the file
    file = open(abs_path_to_contract_test, 'r')
    lines = file.readlines()
    file.close()
    # Performs replacement
    text = "".join(lines)
    text = text.replace(to_replace, replacement)
    # Writes chaages to the contract test
    file = open(abs_path_to_contract_test, 'w')
    file.write(text)
    file.close()


# Builds the solution
def build(solution: "str")-> "None":
    build_command = get_msbuild_command(solution)
    build_output = run_command(build_command)


# Gets the build command to run
def get_msbuild_command(solution: "str")-> "str":
    abs_path_to_solution = get_abs_path(solution)
    abs_path_to_msbuild = get_abs_path("c:\WINDOWS\Microsoft.NET\Framework\\v4.0.30319\MSBuild.exe")
    return f"{abs_path_to_msbuild} {abs_path_to_solution} /t:rebuild"


# Get the contracts and stores them as keys in a dictionary
def get_contracts(contract_test: "str")-> "dict":
    abs_path_to_test = get_abs_path(contract_test)

    file = open(abs_path_to_test)
    lines = file.readlines()
    file.close()

    contracts = dict()

    for line in lines:
        if "PUT_" in line:
            slice_index = line.index("PUT_")
            contract = line[slice_index:]
            slice_index = contract.index('(')
            contract = contract[:slice_index]
            contracts[contract] = None

    return contracts

    # public void PUT_InsertContract([PexAssumeUnderTest]ArrayList arrList, int x, int index)


# Runs pex on each contract
def run_pex(solution: "str", contracts: "dict", assembly: "str")-> "None":
    # The absolute path to the dll
    abs_path_to_assembly = get_abs_path(assembly)
    # Get the problem information for pex
    (test_namespace, test_class) = get_problem_information(solution)
    for contract in contracts:
        pex_command = get_pex_command(abs_path_to_assembly, contract, test_namespace, test_class)
        # Store the pex output for that contract
        contracts[contract] = run_command(pex_command)
        # PARSING XML PEX PRODUCES


# Gets the information that pex needs to run
def get_problem_information(solution: "str")-> "str":
    abs_path_to_solution = get_abs_path(solution)
    delimiter = "\\" if platform.system() is "Windows" else '/'
    contracts_subjects = f"{delimiter}ContractsSubjects{delimiter}"
    slice_index = abs_path_to_solution.index(contracts_subjects)
    problem_name = abs_path_to_solution[slice_index+len(contracts_subjects):]
    slice_index = problem_name.index(delimiter)
    problem_name = problem_name[:slice_index]
    return (f"{problem_name}.Test", f"{problem_name}ContractTest")


# Returns the command to run pex with
def get_pex_command(testDll, testMethod, testNamespace, testClass):
        arguments = ['/nor']
        abs_path_to_pex = get_abs_path("c:\Program Files\Microsoft Pex\\bin\pex.exe") # Might not work on systems other than windows...
        cmd = [abs_path_to_pex, testDll , f"/membernamefilter:M:{testMethod}!", f"/methodnamefilter:{testMethod}!", f"/namespacefilter:{testNamespace}!", f"/typefilter:{testClass}!"]
        cmd.extend(["/ro:root", "/rn:XmlReport", "/rl:Xml"])
        cmd.extend(arguments)
        
        return cmd


# Runs the passed in command
def run_command(args):
    try:
        executionOutput = ""
        executionRun = subprocess.Popen(args, stdout = subprocess.PIPE, stderr = subprocess.PIPE)
        for line in executionRun.stdout:
            executionOutput += os.linesep + str(line.rstrip())
        executionRun.stdout.close()
        return executionOutput
    except OSError as e:
        print('OSError > ', e.errno)
        print('OSError > ', e.strerror)
        print('OSError > ', e.filename)       
        raise OSError
    except:
        print('Error > ', sys.exc_info()[0])
        raise OSError


# Main Method
if __name__ == "__main__":
    # Create the argument parser
    parser = argparse.ArgumentParser()
    # Named argument that collects the contract test, the solution, and the test dll
    parser.add_argument("-run", type=str, nargs=3, required=True)
    # Produces a namespace that maps 'run' to a list filled with the arguments
    args = parser.parse_args()
    # Get the list of arguments
    to_run = args.run
    assert(len(to_run) == 3)
    # The contrat test
    contract_test = to_run[0]
    # The solution
    solution = to_run[1]
    # The assembly file
    assembly = to_run[2]
    # Set upn pex methods within the contract test and run pex
    run(contract_test, solution, assembly)



    