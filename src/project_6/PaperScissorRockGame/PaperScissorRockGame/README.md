# Paper Scissors Rock Game

## Rules

There are three items: 

- Paper 2
- Scissors 3
- Rock 1

Both computers pick those and then system declares the winner based on the rules:

- Scissors beat paper;
- Rock beat Scissors;
- Paper beat Rock;

Draw is counted as outcome of the game trial, so it is counted as well.

## Conditions

After each battle, you have to click "start over again" to reset the deck. This triggers the system to
make computer choose another item. If you do not do it, you can win infinitely and that is accumulated in the
database. I can open this as an issue and easily fix, but I wanted to keep the button for users to have more buttons
to click. I believe that users enjoy buttons and have joy when clicking them.

### Side effect

The system counts all outcomes and you can view history. System remembers the names you used. For my testing,
I used "Alice" and "Igor". I wanted to add validation system to allow certain names, but it took too much time to
finally make that work. Turned out that my biggest mistake was not to install all the packages. I figured out it intuitively.
No ChatGPT thought about it!
