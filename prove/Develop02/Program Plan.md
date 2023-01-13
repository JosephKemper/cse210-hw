Program Outline and requirements.
Display menu for user with the following options
1. Write
2. Display
3. Load
4. Save
5. Quit

Write should give prompt to user for what to write journal entry about, and let them write a journal entry about the prompt. 

The prompt should be randomly pulled from a list of possible journal prompts. 

Hitting enter should finish the journal entry. 

Display should display to console all journal entries, in this format 
Date [show the date the journal entry was written] - Prompt: [Display the prompt the user was given for that journal entry]? [Display journal entry text] 

Save will save the journal to a text file, giving the user a chance to name the file. 

Load will let the user choose the file name that they want to load prior data from, and that will pull up all previously saved data. And that will let them continue the journal as previously entered. 

Quit will end the program. The program should continue to loop until quit is selected from the main menu. 


Main menu -- should loop until quit is selected. Should call all other commands as desired. After completion, with the exception of quit, all other commands should take you back to the main menu. 

---Goal----
Design the whole program into classes
-----------


---class mainMenu---
needs to display the menu options
take input from the user
launch the option the user selects
exit the program when the user desires

---Class WriteJournalEntry---

---Class DisplayJournal---

---Class LoadJournal---

---Class SaveJournal---
