**# Data Structures & Algorithms: College Projects (2nd Year)**

Table of Contents
- Project 1: Grade Manager (2D array)
- Project 2: Stack (card stack)
- Project 3: Grade Search (Windows Forms)



**Project 1: Grade Manager (2D array)**

This is a simple grade management console app that uses a 2D array to store student records. It shows how to use array indexing and basic CRUD (Create, Read, Update, Delete) operations.

Key features
- Add / Edit / Delete / View student records (rows in a 2D array)
- You can navigate the menu using single-key commands (D, E, R, Y) to keep the app running
- Input validation includes a valid operation check, and checking for unique IDs



**Project 2: Stack (card stack)**

A focused console app that demonstrates a stack (LIFO) implemented with System.Collections.Generic.Stack<T>. The app models a stack of card identifiers (e.g., "A-6", "H-5"), and lets the user push new cards and pop the top card while exploring typical stack behavior.

Key features
- Push: add a card on top of the stack, but only if it does not already exist (duplicate check).
- Pop: remove the top card; the program shows the top card with Peek() before removing it.
- Display: list current stack contents from top to bottom (Stack<T> enumerator yields top-first).
- Persistent main loop: single-key-driven flow that keeps the app running until the user exits.
- Simple, human-friendly console I/O for learning and demonstration.




**Project 3: Grade Search (Windows Forms)**

A small Windows Forms app that generates an array of random grades, animates their display, and allows the user to search for a grade value. The UI visualizes matching elements and reports their indices.

Key features (short, including validations)
Project 3: Grade Search (Windows Forms)
This small Windows Forms application creates an array of random grades, displays them with animation, and allows you to search for a specific grade. The UI highlights matches and shows their positions.

Key features (short, including validations)
- Generates an int[8] array of random grades and shows them with a timer-based label animation.
- Search by typing a value in the textbox and pressing Enter. If the input is empty, a required-field warning appears.
- Checks input with int.TryParse only allows values from 0 to 100. Invalid entries show a friendly "Invalid grade!" message.
- Gives step-by-step visual feedback: each element shows a "True" or "False" label in green or red as the timer goes through the array.
- Shows the index or indices for matches, or says "does not exist" if there are none.
- The retry button restarts the process.
