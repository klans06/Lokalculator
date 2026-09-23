# Lokalculator

---

**What should this program do?** It should allow the user to input an infix equation (e.g. `(5 + 10) * 2`), which it will then evaluate into postfix (e.g. `5 10 + 2 *`), then calculate the equation. Displaying both the postfix and the result to the user.

**Why did I make this?** Although working calculators aren't in short supply, I wrote this to understand more about statements, collections, methods, etc. I'm learning this language from scratch without using AI to give direct answers, focusing more on using docs, StackOverflow, Discord and the internet in general to grasp as much as possible about the language.

## Usage

The program is incredibly simple to use:
1. Run the program.
2. Enter an infix notation/equation, e.g. `(5 + 3) * 10`.
3. You will receive the postfix notation conversion and the result of the equation.

**Example Expected I/O**
```
Enter your equation:
(5 + 2) * 3 + ((4 - 1) * (2 + 10))
RPN result: 5 2 + 3 * 4 1 - 2 10 + * +
Result is: 57
```