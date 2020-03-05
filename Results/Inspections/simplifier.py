##Assumptions: Always check k1 post if present then k2
#first list  

#possible contract data_structure
import os

class Predicate:
    def __init__(self, expression):
        self.operators =  [">=", "<=", "==", "<", ">"]
        self.expression = expression
        self.leftOperand = ""
        self.rightOperand = ""
        self.operator = ""

    # still needs work
    def canSimplifyToLessThan(self, other):
        assert(type(other) == type(self))
        self.deconstructExpression()
        other.deconstructExpression()
        canReduce = False
        newExpression = ""

        if other.leftOperand.count("!") > 0 and other.operator == "==":
            if self.operator == "<=":
                if (self.leftOperand == other.rightOperand.replace(")", "") and self.rightOperand.replace(")", "") == other.leftOperand.replace("(", "").replace("!", "")) or (self.leftOperand == other.leftOperand.replace("(", "").replace("!", "") and self.rightOperand.replace(")", "") == other.rightOperand.replace(")", "")):
                    canReduce = True
                    newExpression = f"{self.leftOperand} < {self.rightOperand}"
        # elif self.leftOperand.count("!") > 0 and self.operator == "==":
        #     if other.operator == ">=":
                
        #     elif other.operator == "<=":
        return (canReduce, newExpression)

    def canSimplifyToGreaterThan(self, other):
        assert(type(other) == type(self))
        self.deconstructExpression()
        other.deconstructExpression()
        canReduce = False
        newExpression = ""

        if other.leftOperand.count("!") > 0 and other.operator == "==":
            if self.operator == ">=":
                if (self.leftOperand == other.rightOperand and self.rightOperand == other.leftOperand) or (self.leftOperand == other.leftOperand and self.rightOperand == other.rightOperand):
                    canReduce = True
                    newExpression = f"{self.leftOperand} > {self.rightOperand}"
        return (canReduce, newExpression)

    def canSimplifyToEqual(self, other):
        assert(type(other) == type(self))
        self.deconstructExpression()
        other.deconstructExpression()
        canReduce = False
        newExpression = ""
        if self.operator == "<=" and other.operator == self.operator:
            if self.leftOperand == other.rightOperand and self.rightOperand == other.leftOperand:
                canReduce = True
                newExpression = f"{self.leftOperand} == {self.rightOperand}"
                return (canReduce, newExpression)
        return (canReduce, newExpression)

        
    def deconstructExpression(self):
        self.expression = self.expression.replace(" ", "") # remove white space
        targetOp = ""

        for operator in self.operators:
            if operator in self.expression:
                targetOp = operator
                break
        if targetOp == "":
            self.leftOperand = self.expression
            return
        operands = self.expression.split(targetOp)
        self.operator = targetOp
        self.leftOperand = operands[0]
        self.rightOperand = operands[1]


def CollectPredicates(lines):
    import re
    
    posts = [] # list of predicates
    predicate = []
    insertions = []
    for lineIdx in range(0, len(lines)):
        if "simplified postcondition" in lines[lineIdx]:
            insertions.append(lineIdx + 1)
            colon = lines[lineIdx].index(':') + 1
            postcondition = lines[lineIdx][colon:].lstrip().replace("\n", "")
            posts.append(convert(postcondition))

    return posts, insertions

def convert(postcondition):
    # remove leftmost left paren and rightmost right pare
    postcondition = postcondition[1:-1]
    #split on disjunction
    disjunctiveSplit = postcondition.split("||")
    #remove 0th entry left paren and nth entry right paren
    disjunctiveSplitConverted = [ term.strip()[1:-1]  for term in disjunctiveSplit ]
    #disjunctiveSplit[0] = disjunctiveSplit[0].replace("(", "")
    #predicates is a list of list of string predicates
    predicates = [predicate.split(" && ") for predicate in disjunctiveSplitConverted]
#    for pred in range(0, len(predicates)):
#        predicates[pred] = Simplify(predicates[pred])

    return predicates

### Delegator
def Simplify(postcondition):
    for term in range(0, len(postcondition)):
        postcondition[term] = simplifyToEqual(postcondition[term])
        postcondition[term] = simplifyToLessThan(postcondition[term])
    return postcondition
        

def simplifyToEqual(term):
    simplifiedAwayPredicates = []
    newPredicates = []

    #Match each predicate to every other predicate, but only once
    for first in range(0, len(term) - 1):
        for second in range(first + 1, len(term)):
            firstPredicate = Predicate(term[first])
            secondPredicate = Predicate(term[second])
            (canSimplify, newPredicate) = firstPredicate.canSimplifyToEqual(secondPredicate)
            if canSimplify:
                simplifiedAwayPredicates.append(term[first])
                simplifiedAwayPredicates.append(term[second])
                newPredicates.append(newPredicate)
    for predicate in term:
        if not predicate in simplifiedAwayPredicates:
            newPredicates.append(predicate)
    return newPredicates

def simplifyToLessThan(term):
    simplifiedAwayPredicates = []
    newPredicates = []

    #Match each predicate to every other predicate, but only once
    for first in range(0, len(term) - 1):
        for second in range(first + 1, len(term)):
            firstPredicate = Predicate(term[first])
            secondPredicate = Predicate(term[second])
            (canSimplify, newPredicate) = firstPredicate.canSimplifyToLessThan(secondPredicate)
            if canSimplify:
                simplifiedAwayPredicates.append(term[first])
                simplifiedAwayPredicates.append(term[second])
                newPredicates.append(newPredicate)
    for predicate in term:
        if not predicate in simplifiedAwayPredicates:
            newPredicates.append(predicate)
    return newPredicates

#return a boolean that says wether or not the method factored successfully
def FactorExpression(expression):
    terms = {}
    commonFactors = []
    factoredExpression = []
    
    for clause in expression:
        for term in clause:
            if not term in terms:
                terms[term] = 1
            else:
                terms[term] += 1

    for term in terms:
        if terms[term] == len(expression):
            commonFactors.append(term)

    factoredExpression.append(commonFactors)
    for clause in expression:
        uncommonTerms = []
        for term in clause:
            if terms[term] < len(expression):
                uncommonTerms.append(term)
        factoredExpression.append(uncommonTerms)
    return factoredExpression

def FormatExpression(expression):
    formattedExpression = "(("
    toInsert = expression.pop(0)
    formattedExpression = formattedExpression + " && ".join(toInsert) + ") && ((" if len(toInsert) > 0 else formattedExpression + '('
        
    for index in range(0, len(expression) - 1):
        toInsert = expression.pop(0)
        if len(toInsert) > 0:
            formattedExpression += " && ".join(toInsert) + ") || ("
    toInsert = expression.pop()

    formattedExpression = formattedExpression + " && ".join(toInsert) + ")))" if len(toInsert) > 0 else formattedExpression[:len(formattedExpression) - 6] + ")"
    return formattedExpression

def Insert(path, lines, postsconditions, insertions):
    file = open(path, 'w')
    for lineIdx in range(0, len(lines)):
        lineToWrite = lines[lineIdx]
        if lineIdx in insertions:
            lineToWrite += "CNF simplified: " + postsconditions.pop(0) + "\n\n"
        file.write(lineToWrite)
    file.close()

if __name__ == "__main__":
    import argparse
    parser = argparse.ArgumentParser()

    parser.add_argument("--inspection-file", "-i", type=str, nargs=argparse.ONE_OR_MORE, required=True)
    args = parser.parse_args()

    inspection = args.inspection_file

    for fileName in inspection:
        path = os.path.abspath(fileName)
        file = open(path, 'r')
        lines = file.readlines()
        file.close()
        (postconditions, insertions) = CollectPredicates(lines)
        for postIdx in range(0, len(postconditions)):
            postconditions[postIdx] = Simplify(postconditions[postIdx])
            postconditions[postIdx] = FactorExpression(postconditions[postIdx])
            postconditions[postIdx] = FormatExpression(postconditions[postIdx])
        Insert(path, lines, postconditions, insertions)
