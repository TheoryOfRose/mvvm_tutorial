// ---------------------------------------------------------------------
// <copyright file="StudentView.xaml.cs" company="AIRS Medical Inc">
// Copyright (c) AIRS Medical Inc. All rights reserved.
// See LICENSE file in the project root for full license information.
// SwiftMR can not be copied and/or distributed without the express permission of AIRS Medical Inc.
// </copyright>
// ---------------------------------------------------------------------

using System.Windows.Controls;

namespace MVVMDemo.Views
{
  /// <summary>
  /// StudentView.xaml에 대한 상호 작용 논리.
  /// </summary>
  public partial class StudentView : UserControl
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="StudentView"/> class.
    /// </summary>
    public StudentView()
    {
      this.InitializeComponent();
      this.DataContext = new MVVMDemo.ViewModel.StudentViewModel();
    }
  }
}
