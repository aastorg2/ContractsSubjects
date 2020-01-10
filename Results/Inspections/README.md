# Guide for Analyze.py and Inspect.py

> ### Requirements:
> - Python version: 3.7 and pip

#### Analyze.py
---
> This Script used to analyze inspections results.
> The results will be printed to standard console.
> When running command, use --file or -f flag to input the run file you wish to analyze.
> ##### EXAMPLE USESAGE:
>> ```sh
>> $ python.exe analyze.py --file `inspection_file_you_wish_to_analyze.txt`
>> ```
> In a direcotry that contains:
>> - inspected_results_StackTest.txt
> and you were to run the analye script...
>> ```sh
>> $ python.exe analyze.py --file inspected_results_StackTest.txt
>> ```
> The output would look something like this:
>> RESULTS
>> ---
>> Total Contracts: 5 <br>
>> Number of truly disjunctive contracts: 3 <br>
>> Number of correct disjunctive contracts found using PexChoose: 1/3 <br>
>> Number of correct disjunctive contracts found using Alternate Semantics: 3/3 <br>
>> Number of truly conjunctive contracts found (PexChoose): 1/2 <br>
>> Correct disjunctive contracts found with PexChoose: <br>
>> &emsp;&emsp;PUT_ContainsContract <br>
>> Correct disjunctive contracts missed with PexChoose: <br>
>> &emsp;&emsp;PUT_PushContract <br>
>> &emsp;&emsp;PUT_PopContract <br>
>> correct Conjunctive contracts found with PexChoose: <br>
>> &emsp;&emsp;PUT_PeekContract <br>
>> Correct conjunctive contracts missed with PexChoose: <br>
>> &emsp;&emsp;PUT_CountContract

#### Inspect.py
---
> This Script used to generate inspections results from a run file.
> The inspection file will be generated in the working directory with "inspected" appened to the front of the run file name.
> #### Flags
>> * `--pex`, `-p`: Use this flag to input the run file done under PexChoose semantics
>> * `--alternate`, `-A`: Use this flag to input the run file done under alternate semantics (if used, must also use --pex flag)
>> * `--agreemnet`, `-a`: Use this flag to over-write an inspection file with another inspection file
> ##### EXAMPLE USESAGEs:
>> ```sh
>> $ python.exe inspect.py --pex `pex_run_file_you_wish_to_inspect.txt`
>> ```
>> ---
>> ```sh
>> $ python.exe inspect.py --pex `pex_run_file_you_wish_to_inspect.txt` --alternate `alternate_run_file_you_wish_to_inspect.txt`
>> ```
>> ---
>> ```sh
>> $ python.exe inspect.py --agreement `inspection_file_to_overwirte.txt` `inspection_file_to_write_from.txt`
>> ```
> In a direcotry that contains:
>> - results_StackTest.txt
> and you were to run the inspect script with just the pex flag...
>> ```sh
>> $ python.exe inspect.py --pex results_StackTest.txt
>> ```
> The working dircetory would now contain:
>> - inspected_results_StackTest.txt
>> - results_StackTest.txt <br>
> Whose contents would contain one or more contracts like this: <br>
>> PUT_PushContract
>>
>> Disjunctive (PexChoose): <br>
>> Disjunctive (Alternate Semantics): <br>
>> Disjunctive (Truly): <br>
>>
>> ---
>> k == 0
>>
>> learned postcondition: (New_s1ContainsX && New_s1Count == Old_s1Count + 1 && New_Top == Old_x && New_x == Old_x && New_s1Count != Old_s1Count && Old_x == New_Top && New_x == New_Top)
>>
>> simplified postcondition: ((New_s1ContainsX && New_s1Count == 1 + Old_s1Count && Old_x == New_Top && New_x == New_Top))
>>
>> predicate: None
>> 
>> predicate right: None
>> 
>> predicate left: None
>> 
>> Any:
>>
>> L:
>>
>> SubL:
>>
>> pex time: 188.06009721755981
>>
>> learn time: 8.839656591415405
>> 
>> Samples: 15
>>
>> ---
>> k == 1
>> 
>> learned postcondition: (New_s1ContainsX && New_s1Count == Old_s1Count + 1 && New_Top == Old_x && New_x == Old_x && New_s1Count != Old_s1Count && Old_x == New_Top && New_x == New_Top)
>>
>> simplified postcondition: ((New_s1ContainsX && New_s1Count == 1 + Old_s1Count && Old_x == New_Top && New_x == New_Top))
>>
>> predicate: None
>>
>> predicate right: None
>>
>> predicate left: None
>>
>> Any:
>>
>> L:
>>
>> SubL:
>>
>> pex time: 290.4679591655731
>>
>> learn time: 98.27935433387756
>>
>> Samples: 40
>>
>> k0 -> k1: True
>> 
>> k1 -> k0: True
>>
>> ---
>> k == 2
>>
>> learned postcondition: (New_s1ContainsX && New_s1Count == Old_s1Count + 1 && New_Top == Old_x && New_x == Old_x && New_s1Count != Old_s1Count && Old_x == New_Top && New_x == New_Top)
>>
>> simplified postcondition: ((New_s1ContainsX && New_s1Count == 1 + Old_s1Count && Old_x == New_Top && New_x == New_Top))
>> 
>> predicate: None
>>
>> predicate right: None
>> 
>> predicate left: None
>>
>> pex time: 227.7580122947693
>>
>> learn time: 124.54550075531006
>>
>> Samples: 39
>> 
>> k0 -> k2: True
>>
>> k1 -> k2: True
>
> <strong>Note</strong>: Some of the entries have to filled out by the user