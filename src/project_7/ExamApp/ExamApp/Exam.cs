using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace ExamApp
{
    public partial class Exam : Form
    {

        public List<Question> questions;
        private int currentQuestionIndex = 0;
        private System.Timers.Timer questionTimer;
        private const int TimePerQuestionInSeconds = 45;

        public Exam()
        {
            InitializeComponent();
            InitializeQuestions();
            InitializeTimer();

        }

        private void Exam_Load(object sender, EventArgs e)
        {
            
        }

        private void ExamCtlPanel_Enter(object sender, EventArgs e)
        {

        }

        private void NextBtn_MouseClick(object sender, MouseEventArgs e)
        {
            MoveToNextQuestion();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            MoveToPrevQuestion();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            // Stop the timer, as the exam is being finished
            questionTimer.Stop();

            // Calculate the score
            int correctAnswers = 0;
            foreach (var question in questions)
            {
                if (question.UserAnswer == question.CorrectAnswer)
                {
                    correctAnswers++;
                }
            }

            // Calculate the total score as a percentage
            int scorePercentage = (correctAnswers * 100) / questions.Count;

            // Display the result to the user
            MessageBox.Show($"Exam Finished!\nYou scored: {correctAnswers} out of {questions.Count} ({scorePercentage}%)");
        }

        private void StartExamBtn_Click(object sender, EventArgs e)
        {
            // start the exam
            if(QuestionValue.Text != "")
            {
                MessageBox.Show("Cannot start the exam, because it has been started!");
            }

            ShowQuestion(this.questions[0]);
            this.QuestionNr.Text = $"{this.currentQuestionIndex + 1}";
        }

        private void StartTimer()
        {
            questionTimer.Start();
            timerLabel.Text = TimePerQuestionInSeconds.ToString();  // Set initial timer value
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Update the timer display
            if (InvokeRequired)
            {
                Invoke(new Action(() => timerLabel.Text = (int.Parse(timerLabel.Text) - 1).ToString()));
            }
            else
            {
                timerLabel.Text = (int.Parse(timerLabel.Text) - 1).ToString();
            }

            if (int.Parse(timerLabel.Text) <= 0)
            {
                // Time's up, automatically move to next question
                questionTimer.Stop();
                MoveToNextQuestion();
            }
        }

        private void MoveToNextQuestion()
        {
            // Increase index and check for bounds
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                ShowQuestion(questions[currentQuestionIndex]);
                this.StartTimer();
                this.QuestionNr.Text = $"{currentQuestionIndex+1}";
            }
            else
            {
                // End of the exam
                MessageBox.Show("You have completed the exam!");
                // Optionally, you could display the results here.
            }
        }

        private void MoveToPrevQuestion()
        {
            // Decrease index and check for bounds
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                ShowQuestion(questions[currentQuestionIndex]);
                this.QuestionNr.Text = $"{currentQuestionIndex+1}";
                StartTimer();
            }
        }


        private void ShowQuestion(Question question)
        {
            QuestionValue.Text = question.Title;
            OptionAValue.Text = question.Options[0];
            OptionBValue.Text = question.Options[1];
            OptionCValue.Text = question.Options[2];
            OptionDValue.Text = question.Options[3];
        }


        private void InitializeQuestions()
        {
            Question[] questions = {
                new Question("What is the legal blood alcohol concentration (BAC) limit for drivers in most jurisdictions?", new string[]{"0.02%", "0.05%", "0.08%", "0.10%"}, 'C'),
                new Question("What does a red traffic light mean?", new string[]{"Slow down and proceed with caution", "Stop and wait for the green light", "Turn right immediately", "Yield to pedestrians"}, 'B'),
                new Question("When should you use your turn signals?", new string[]{"Only when turning", "When changing lanes or turning", "Only at intersections", "When you are stopped at a red light"}, 'B'),
                new Question("Which of the following is a safe following distance?", new string[]{"1 car length", "2 car lengths", "3 seconds of space", "4 seconds of space"}, 'C'),
                new Question("When driving in foggy conditions, you should use:", new string[]{"High beams", "Low beams", "Hazard lights", "Parking lights"}, 'B'),
                new Question("What does a yellow diamond-shaped sign indicate?", new string[]{"Warning of potential hazards ahead", "Speed limit", "A stop sign", "A hospital zone"}, 'A'),
                new Question("When should you yield the right of way to pedestrians?", new string[]{"Only at crosswalks", "At any intersection", "Only when turning left", "Only when there are no vehicles around"}, 'B'),
                new Question("What should you do if you are approaching an intersection and the traffic lights are not working?", new string[]{"Drive through carefully", "Treat it as a yield sign", "Treat it as a stop sign", "Keep driving without stopping"}, 'C'),
                new Question("What is the minimum age to obtain a driver's license in most areas?", new string[]{"16 years old", "18 years old", "21 years old", "17 years old"}, 'D'),
                new Question("What should you do if you are involved in a car accident?", new string[]{"Leave the scene immediately", "Exchange information with the other driver", "Ignore the damage if it’s minor", "Call a friend for help"}, 'B'),
                new Question("If you are driving in a roundabout, who has the right of way?", new string[]{"The vehicle entering the roundabout", "The vehicle already in the roundabout", "The first vehicle in line", "The vehicle going slower"}, 'B'),
                new Question("When must you stop for a school bus?", new string[]{"Only when the bus has its lights flashing", "Only if you are on the same side of the road as the bus", "When the bus is moving", "When there are no children around"}, 'B'),
                new Question("When parking uphill with a curb, which direction should you turn your front wheels?", new string[]{"Left (toward the curb)", "Right (away from the curb)", "It doesn't matter", "Left (away from the curb)"}, 'B'),
                new Question("What is the purpose of a three-point turn?", new string[]{"To reverse in a straight line", "To make a U-turn", "To change lanes quickly", "To turn around in a narrow space"}, 'D'),
                new Question("Which of the following is an example of distracted driving?", new string[]{"Using hands-free phone systems", "Talking to passengers", "Adjusting your car’s stereo while driving", "Looking in the rearview mirror"}, 'C'),
                new Question("What is the best way to avoid hydroplaning on wet roads?", new string[]{"Speed up to avoid water accumulation", "Keep your tires properly inflated", "Turn on your windshield wipers", "Brake hard to slow down"}, 'B'),
                new Question("What does a green arrow at an intersection mean?", new string[]{"Proceed in the direction of the arrow", "Stop and wait for traffic to clear", "Yield to pedestrians", "Prepare to stop"}, 'A'),
                new Question("If you are approaching a railroad crossing and the lights are flashing, what should you do?", new string[]{"Speed up to get across quickly", "Stop and wait for the lights to stop flashing", "Look both ways and proceed slowly", "Stop only if the train is coming"}, 'B'),
                new Question("When is it legal to pass another vehicle on the right?", new string[]{"When the vehicle in front is turning left", "At any time on a two-lane road", "Only on highways", "When you are in a hurry"}, 'A'),
                new Question("What should you do if your vehicle begins to skid?", new string[]{"Steer in the opposite direction of the skid", "Steer in the same direction of the skid", "Keep your foot on the accelerator", "Slam on the brakes immediately"}, 'B')
            };

            this.questions = questions.ToList();
        }

        private void InitializeTimer()
        {
            this.questionTimer = new System.Timers.Timer
            {
                Interval = 1000 // 1 second intervals
            };
            questionTimer.Elapsed += OnTimerElapsed;
        }

        private void QuestionSlide_Enter(object sender, EventArgs e)
        {

        }

        private void OptionA_CheckedChanged(object sender, EventArgs e)
        {
            // get the current question
            this.questions[this.currentQuestionIndex].UserAnswer = 'A';

        }

        private void OptionB_CheckedChanged(object sender, EventArgs e)
        {
            this.questions[this.currentQuestionIndex].UserAnswer = 'B';
        }

        private void OptionC_CheckedChanged(object sender, EventArgs e)
        {
            this.questions[this.currentQuestionIndex].UserAnswer = 'C';
        }

        private void OptionD_CheckedChanged(object sender, EventArgs e)
        {
            this.questions[this.currentQuestionIndex].UserAnswer = 'D';
        }

        private void ViewResultBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Results results = new Results(this.questions);
            results.Show();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to leave?", "Confirm leaving", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Exit Canceled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int CalculateScore(char[] userAnswers)
        {
            int score = 0;
            for (int i = 0; i < this.questions.Count; i++)
            {
                if (this.questions[i].CorrectAnswer == userAnswers[i])
                {
                    score++;
                }
            }
            return score;
        }
    }
}
