﻿using Digimezzo.WPFControls;
using Knowte.Core.Base;
using Knowte.Core.Extensions;
using System.Windows;

namespace Knowte.Common.Services.Dialog
{
    /// <summary>
    /// Interaction logic for ConfirmationDialog.xaml
    /// </summary>
    public partial class ConfirmationDialog : BorderlessWindows8Window
    {
        #region Construction
        public ConfirmationDialog(Window parent, int iconCharCode, int iconSize, string title, string content, string okText, string cancelText) : base()
        {
            InitializeComponent();

            this.TitleBarHeight = Defaults.DefaultWindowButtonHeight + 10;
            this.Icon.Text = char.ConvertFromUtf32(iconCharCode);
            this.Icon.FontSize = iconSize;
            this.Title = title;
            this.TextBlockTitle.Text = title;
            this.TextBlockContent.Text = content;
            this.ButtonOK.Content = okText;
            this.ButtonCancel.Content = cancelText;

            this.CenterWindow(parent);
        }
        #endregion

        #region Event Handlers
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        #endregion
    }
}
