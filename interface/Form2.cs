using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form2 : Form
    {
        bool gateIsOpen;
        List<PictureBox> cars = new List<PictureBox>();
        List<PictureBox> trains = new List<PictureBox>();
        Random random = new Random();
        Timer trainTimer = new Timer();
        int points = 0;
        public Form2()
        {
            InitializeComponent();
            Start();
        }
        void Start() {
            Timer carMoveTimer = new Timer();
            carMoveTimer.Interval = 25;
            carMoveTimer.Tick += CarMoveTimer;
            carMoveTimer.Start();
            gateIsOpen = false;

            Timer carTimer = new Timer();
            carTimer.Interval = 10;
            carTimer.Tick += CarTimer;
            carTimer.Start();

            Timer trainMoveTimer = new Timer();
            trainMoveTimer.Interval = 10;
            trainMoveTimer.Tick += TrainMoveTimer;
            trainMoveTimer.Start();
            gateIsOpen = false;

            trainTimer.Interval = 1000;
            trainTimer.Tick += TrainTimer;
            trainTimer.Start();

            Timer gateTimer = new Timer();
            gateTimer.Interval = 10;
            gateTimer.Tick += GateTick;
            gateTimer.Start();
            gateIsOpen = true;

            crossingbtn.Click += CrossingGate;
        }
        void CrossingGate(object s, EventArgs e) {
            gateIsOpen = !gateIsOpen;
        }
        void CarMoveTimer(object s, EventArgs e)
        {
            for (int i = cars.Count - 1; i >= 0; i--)
            {
                PictureBox car = cars[i];

                if (!gateIsOpen && car.Location.X > 199)
                {
                    MoveCar(car);
                }
                else if (gateIsOpen)
                {
                    MoveCar(car);
                }

                if (car.Location.X >= 480)
                {
                    Controls.Remove(car);
                    cars.RemoveAt(i);
                    points++;
                    pointslabel.Text = $"Points: {points}";
                }
            }
        }
        void MoveCar(PictureBox car)
        {
            car.Left += 2;
            car.BringToFront();
        }
        void CarTimer(object s, EventArgs e)
        {
            if (cars.Count == 0) {
                SpawnCar();
            }
            if (cars[cars.Count - 1].Location.X >= 51) {
                SpawnCar();
            }
            
        }

        void TrainMoveTimer(object s, EventArgs e)
        {
            for (int i = trains.Count - 1; i >= 0; i--)
            {
                PictureBox train = trains[i];
                train.Top -= 4;
                train.BringToFront();

                if (train.Location.Y <= -100)
                {
                    Controls.Remove(train);
                    trains.RemoveAt(i);
                }

                for (int j = cars.Count - 1; j >= 0; j--)
                {
                    PictureBox car = cars[j];
                    if (train.Bounds.IntersectsWith(car.Bounds))
                    {
                        Controls.Remove(car);
                        cars.RemoveAt(j);
                        points--;
                        pointslabel.Text = $"Points: {points}";

                        break; 
                    }
                }
            }
        }
        void TrainTimer(object s, EventArgs e)
        {
            SpawnTrain();
        }
        void SpawnCar() {
            Color randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            PictureBox car = new PictureBox();
            car.Location = carspawn.Location;
            car.Size = carspawn.Size;
            car.BackColor = randomColor;
            car.BringToFront();
            cars.Add(car);
            Controls.Add(car);
        }
        void SpawnTrain()
        {
            Color randomColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            PictureBox train = new PictureBox();
            train.Location = trainspawner.Location;
            train.Size = trainspawner.Size;
            train.BackColor = randomColor;
            train.BringToFront();
            trains.Add(train);
            Controls.Add(train);
            trainTimer.Interval = random.Next(5000,10000);
        }
        void GateTick(object s, EventArgs e) {
            if (gateIsOpen)
            {
                if (crossing.Location.Y != 71) {
                    crossing.Top--;
                }
            }
            else {
                if (crossing.Location.Y != 138)
                {
                    crossing.Top++;
                }
            }
        }


    }
}
