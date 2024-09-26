# Quizz Desktop App

## How to use?

There are only 3 questions that you can ask (per quizz). In order to try out, 
please use `git clone` and let Visual Studio set up the project. Then, go to
`Data/Questions` and modify your questions, then modify 'CorrectAnswers.csv'.

That is it! You have to type and confirm your entered result (by pressing button).
Then you can save results and only then check, because the logic of checking
results is load saved data and then check. The application also explains answers.

Go to `Data/Questions` and modify explanations.


Remark: CSV is really slow, so for real projects, it is better to use SQLite.
