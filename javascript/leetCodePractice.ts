/**
 * Running with: npx tsx leetCodePractice.ts
 */

const question1 = {
    title: "Best Time to buy stocks",
    prompt: "You are given an array prices where prices[i] is the price of a given stock on the ith day.\n" +
        "    You want to maximize your profit by choosing a single day to buy one stock and choosing a\n" +
        "different day in the future to sell that stock.\n" +
        "    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0."
}

console.log({ question1 })

const getStonks = (prices: number[]): number => {

    let profit = 0

    prices.forEach((firstPrice, firstIndex) => {

        prices.forEach((secondPrice, secondIndex) => {
            if (secondIndex <= firstIndex) return

            const temporaryProfit = secondPrice - firstPrice
            if (temporaryProfit > profit)
                profit = temporaryProfit
        })
    })

    return profit
}

const result1 = getStonks([7,1,5,3,6,4])
const answer1 = 5
const result2 = getStonks([7,6,4,3,1])
const answer2 = 0
const result3 = getStonks([2, 2, 2, 2])
const answer3 = 0
const result4 = getStonks([0,6,4,3,10])
const answer4 = 10
const result5 = getStonks([1,6,10,3,1])
const answer5 = 9

console.log({ correct: result1 === answer1, result1, answer1 })
console.log({ correct: result2 === answer2, result2, answer2 })
console.log({ correct: result3 === answer3, result3, answer3 })
console.log({ correct: result4 === answer4, result4, answer4 })
console.log({ correct: result5 === answer5, result5, answer5 })

console.log("-----------------------------")
const question2 = {
    title: "Palindrome",
    prompt: "A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward." +
        "\n Alphanumeric characters include letters and numbers." +
        "\n Given a string s, return true if it is a palindrome, or false otherwise."
}
console.log({ question2 })

const isPalindrome = (myString: string): boolean => {

    const myAlphanumericString = myString.replace(/[^0-9a-zA-Z]/g, '').toLowerCase();

    const reversedString = myAlphanumericString.split('').reverse().join('')

    return myAlphanumericString === reversedString
}

const palindrome1 = "A man, a plan, a canal: Panama"
const palindromeResult1 = isPalindrome(palindrome1)
const palindromeAnswer1 = true
console.log({ correct: palindromeResult1 === palindromeAnswer1, palindrome1 })

const palindrome2 = "race a car"
const palindromeResult2 = isPalindrome("race a car")
const palindromeAnswer2 = false
console.log({ correct: palindromeResult2 === palindromeAnswer2, palindrome2 })

const palindrome3 = " "
const palindromeResult3 = isPalindrome(palindrome3)
const palindromeAnswer3 = true
console.log({ correct: palindromeResult3 === palindromeAnswer3, palindrome3 })

console.log('------------------------------------------------------------------------------------------------------------------------------------------------------------')
const question3 = {
    title: 'Valid Parenthesis',
    prompt: "Given a string s containing just the characters  '(', ')', '{', '}', '[' and ']', determine if the input string is valid." +
        "\n  An input string is valid if: " +
        "\n- Open brackets must be closed by the same type of brackets." +
        "\n- Open brackets must be closed in the correct order." +
        "\n- Every close bracket has a corresponding open bracket of the same type."

}
console.log({ question3 })

const isParenthesisValid = (parenthesisString: string): boolean => {

    const regexExpression = new RegExp(/\(\)|\[\]|\{\}/g);

    return regexExpression.test(parenthesisString)
}

const parenthesisString1 = '()'
const parenthesisValid1 = isParenthesisValid(parenthesisString1)
const parenthesisAnswer1 = true
console.log({ correct: parenthesisValid1 === parenthesisAnswer1, parenthesisString1 })

const parenthesisString2 = "()[]{}"
const parenthesisValid2 = isParenthesisValid(parenthesisString2)
const parenthesisAnswer2 = true
console.log({ correct: parenthesisValid2 === parenthesisAnswer2, parenthesisString2 })

const parenthesisString3 = '(]'
const parenthesisValid3 = isParenthesisValid(parenthesisString3)
const parenthesisAnswer3 = false
console.log({ correct: parenthesisValid3 === parenthesisAnswer3, parenthesisString3 })

const parenthesisString4 = '([])'
const parenthesisValid4 = isParenthesisValid(parenthesisString4)
const parenthesisAnswer4 = true
console.log({ correct: parenthesisValid4 === parenthesisAnswer4, parenthesisString4 })

const parenthesisString5 = '([)]'
const parenthesisValid5 = isParenthesisValid(parenthesisString5)
const parenthesisAnswer5 = false
console.log({ correct: parenthesisValid5 === parenthesisAnswer5, parenthesisString5 })


console.log('------------------------------------------------------------------------------------------------------------------------------------------------------------')
const question4 = {
    title: 'Merge Two Sorted Lists',
    prompt: "You are given the heads of two sorted linked lists list1 and list2.\n" +
        "Merge the two lists into one sorted list.\n" +
        "The list should be made by splicing together the nodes of the first two lists.\n" +
        "Return the head of the merged linked list."

}
console.log({ question4 })


// Definition for singly-linked list.
class ListNode {
  val: number
  next: ListNode | null
  constructor(val?: number, next?: ListNode | null) {
      this.val = (val===undefined ? 0 : val)
      this.next = (next===undefined ? null : next)
  }
}

const mergeTwoLists = (list1: ListNode | null, list2: ListNode | null): ListNode | null => {
    const listThatShouldHaveBeenAListToBeginWith = []

    const getNextNodeValue = (stupidListNode: ListNode) => {
        if (stupidListNode === null || stupidListNode?.val === null) return

        listThatShouldHaveBeenAListToBeginWith.push(stupidListNode.val)

        if (stupidListNode.next !== null) {
            getNextNodeValue(stupidListNode.next)
        }
    }

    getNextNodeValue(list1)
    getNextNodeValue(list2)

    const sortedList = listThatShouldHaveBeenAListToBeginWith.sort()

    const firstInstance = new ListNode()
    let currentInstance: ListNode

    sortedList.forEach((number, index) => {
        if (number === null) return

        if (index === 0) {
            firstInstance.val = number
            currentInstance = firstInstance
        } else {
            const newListNode = new ListNode(number)

            currentInstance.next = newListNode
            currentInstance = newListNode
        }
    })

    return sortedList.length > 0 ? firstInstance : null
};

const list1 = new ListNode(1, new ListNode(2, new ListNode(4)))
const list2 = new ListNode(1, new ListNode(3, new ListNode(4)))

const mergedList1 = mergeTwoLists(list1, list2)
const expectedList1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))))
console.log({ correct: expectedList1.toString() === mergedList1.toString(), expectedList1, mergedList1 })

const mergedList2 = mergeTwoLists(null, null)
const expectedList2 = null
console.log({ correct: expectedList2?.toString() === mergedList2?.toString(), expectedList2, mergedList2 })

const mergedList3 = mergeTwoLists(new ListNode(), new ListNode(0))
const expectedList3 = new ListNode(0)
console.log({ correct: expectedList3.toString() === mergedList3.toString(), expectedList3, mergedList3 })