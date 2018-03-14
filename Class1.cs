using System;

using System.Collections.Generic;

using System.Drawing;

using System.IO;

using System.Runtime.Serialization;

using System.Runtime.Serialization.Formatters.Binary;

using System.Windows.Forms;



namespace KidsGame.ClassLibrary

{

    [Serializable]

    public class Player

    {

        private string name;

        private string password;

        private int score;

        private int highscore;

        private Image avatar;

        private const string fileName = "Players.bin";



        public Player(string name, string password, int score, int highscore, Image avatar)

        {

            this.name = name;

            this.password = password;

            this.score = score;

            this.highscore = highscore;

            this.avatar = avatar;

        }





        public string Name

        {

            get { return name; }

        }



        public string Password

        {

            get { return password; }

            set { password = value; }

        }

        public int Score

        {

            get { return score; }

            set { score = value; }

        }



        public int HighScore

        {

            get { return highscore; }

            set { highscore = value; }

        }



        public Image Avatar

        {

            get { return avatar; }

            set { avatar = value; }

        }



        public static void Save(List<Player> players)

        {

            try

            {

                using (Stream stream = File.Open(fileName, FileMode.Create))

                {

                    BinaryFormatter binFormatter = new BinaryFormatter();

                    binFormatter.Serialize(stream, players);

                    stream.Close();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);



            }

        }



        public static void Load(ref List<Player> players)

        {

            try

            {

                using (Stream stream = File.Open(fileName, FileMode.Open))

                {

                    BinaryFormatter binFormatter = new BinaryFormatter();

                    players = (List<Player>)binFormatter.Deserialize(stream);

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