// ---------------------------------------------------------------------
// <copyright file="StudentViewModel.cs" company="AIRS Medical Inc">
// Copyright (c) AIRS Medical Inc. All rights reserved.
// See LICENSE file in the project root for full license information.
// SwiftMR can not be copied and/or distributed without the express permission of AIRS Medical Inc.
// </copyright>
// ---------------------------------------------------------------------

using MVVMDemo.Model;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModel
{
  /// <summary>
  /// fdsafasfdsafsadf.
  /// </summary>
  public class StudentViewModel
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="StudentViewModel"/> class.
    /// </summary>
    public StudentViewModel()
    {
      this.LoadStudents();
    }

    /// <summary>
    /// Gets or sets students.
    /// </summary>
    public ObservableCollection<StudentModel> Students
    {
      get;
      set;
    }

    /// <summary>
    /// laod
    /// </summary>
    public void LoadStudents()
    {
      ObservableCollection<StudentModel> students = new ObservableCollection<StudentModel>();

      students.Add(new StudentModel { FirstName = "Mark", LastName = "Allain" });
      students.Add(new StudentModel { FirstName = "Allen", LastName = "Brown" });
      students.Add(new StudentModel { FirstName = "Linda", LastName = "Hamerski" });

      this.Students = students;
    }
  }
}
