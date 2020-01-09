# Guide for Analyze.py and Inspect.py

> ### Requirements:
> - Python version: 3.7 and pip

#### Analyze.py
---

> This Script used to analyze inspections results.
> The results will be printed to standard console.
> When running command, use --file or -f flag to input the run file you wish to analyze.
>
> ##### EXAMPLE USESAGE:
> ---
>>
>> ```sh
>> $ python.exe analyze.py --file `run_file_you_wish_to_analyze.txt`
>> ```
> In a direcotry that contains:
> - results_StackTest.txt
> and you were to run the analye script...
>> ```sh
>> $ python.exe analyze.py --file results_StackTest.txt
>> ```
> The output would look something like this:
>
>> RESULTS
>> ---
>> Total Contracts: 5
>> Number of truly disjunctive contracts: 3 <br>
>> Number of disjunctive contracts found using PexChoose: 1/3 <br>
>> Number of disjunctive contracts found using Alternate Semantics: 3/3 <br>
>> Number of contracts found when disjunctive (PexChoose): 1 <br>
>> Number of contracts found when conjunctive (PexChoose): 2 <br>
>> Disjunctive contracts found with PexChoose:
>>         PUT_ContainsContract
>> Disjunctive contracts missed with PexChoose:
>>         PUT_PushContract
>>         PUT_PopContract
>> Conjunctive contracts found with PexChoose:
>>         PUT_PeekContract
>>         PUT_CountContract

#### Inspect.py
---

> This Script used to generate inspections results from a run file.
> The inspection file will be generated in the working directory with "inspected" appened to the front of the run file name.
>