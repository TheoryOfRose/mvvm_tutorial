// ---------------------------------------------------------------------
// <copyright file="StudentModel.cs" company="AIRS Medical Inc">
// Copyright (c) AIRS Medical Inc. All rights reserved.
// See LICENSE file in the project root for full license information.
// SwiftMR can not be copied and/or distributed without the express permission of AIRS Medical Inc.
// </copyright>
// ---------------------------------------------------------------------

using System.ComponentModel;

namespace MVVMDemo.Model
{
    /// <summary>
    /// Student.
    /// </summary>
    public class StudentModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        /// <summary>
        /// property1.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets firstname.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                    this.RaisePropertyChanged("FirstName");
                    this.RaisePropertyChanged("FullName");
                }
            }
        }

        /// <summary>
        /// Gets or sets lastname.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.lastName != value)
                {
                    this.lastName = value;
                    this.RaisePropertyChanged("LastName");
                    this.RaisePropertyChanged("FullName");
                }
            }
        }

        /// <summary>
        /// Gets fullname.
        /// </summary>
        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        /// <summary>
        /// raise property changed.
        /// </summary>
        /// <param name="property">property.</param>
        private void RaisePropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
