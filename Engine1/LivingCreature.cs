﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public int MaxHitPoints { get; set; }

        private int _currentHitPoints;

        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public LivingCreature(int currentHitPoints, int maxHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaxHitPoints = maxHitPoints;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}