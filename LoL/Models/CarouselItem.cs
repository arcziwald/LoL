using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LoL.Models
{
    public class CarouselItem : Sign, INotifyPropertyChanged
    {
        private double _position;
        private double _rotation;
        private double _scale;
        private bool _isDescVisible;
        public CarouselItem()
        {
            Scale = 1;
        }

        public double Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        public double Rotation
        {
            get { return _rotation; }
            set
            {
                _rotation = value;
                OnPropertyChanged();
            }
        }

        public double Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                OnPropertyChanged();
            }
        }
        public bool IsDescVisible
        {
            get { return _isDescVisible; }
            set
            {
                _isDescVisible = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
