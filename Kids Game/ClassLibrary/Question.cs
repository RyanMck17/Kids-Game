using System;

using System.Collections.Generic;

using System.Drawing;

using System.IO;

using System.Runtime.Serialization;

using System.Runtime.Serialization.Formatters.Binary;

using System.Windows.Forms;



namespace Kids_Game.ClassLibrary

{

    [Serializable]

    public class Question

    {

        private string questionTitle;

        private string choice1;

        private string choice2;

        private string choice3;

        private string answer;

        private bool beenAnswered;

        private Image picture;

        private string level; // Easy or Hard 

        private const string fileName = "Question.bin";





        public Question(string questionTitle, string choice1, string choice2, string choice3,

            string answer, bool beenAnswered, Image picture, string level)

        {

            this.questionTitle = questionTitle;

            this.choice1 = choice1;

            this.choice2 = choice2;

            this.choice3 = choice3;

            this.answer = answer;

            this.beenAnswered = beenAnswered;

            this.picture = picture;

            this.level = level;

        }





        public string QuestionTitle

        {

            get { return questionTitle; }

        }

        public string Choice1

        {

            get { return choice1; }

            set { choice1 = value; }

        }



        public string Choice2

        {

            get { return choice2; }

            set { choice2 = value; }

        }



        public string Choice3

        {

            get { return choice3; }

            set { choice3 = value; }

        }

        public string Answer

        {

            get { return answer; }

            set { answer = value; }

        }

        public bool BeenAnswered

        {

            get { return beenAnswered; }

            set { beenAnswered = value; }

        }



        public Image Picture

        {

            get { return picture; }

            set { picture = value; }

        }

        public string Level

        {

            get { return level; }

            set { level = value; }

        }



        public static void Save(List<Question> questions)

        {

            try

            {

                using (Stream stream = File.Open(fileName, FileMode.Create))

                {

                    BinaryFormatter binFormatter = new BinaryFormatter();

                    binFormatter.Serialize(stream, questions);

                    stream.Close();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);



            }

        }



        public static void Load(ref List<Question> questions)

        {

            try

            {

                using (Stream stream = File.Open(fileName, FileMode.Open))

                {

                    BinaryFormatter binFormatter = new BinaryFormatter();

                    questions = (List<Question>)binFormatter.Deserialize(stream);

                    stream.Close();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);



            }

        }

    }

}