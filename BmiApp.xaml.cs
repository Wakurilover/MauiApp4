using System;
using Microsoft.Maui.Controls;

namespace MauiApp4
{
    public partial class BmiApp : ContentPage
    {
        public BmiApp()
        {
            InitializeComponent();
        }

        // ฟังก์ชันคำนวณ BMI เมื่อกดปุ่ม
        void OnCalculateClicked(object sender, EventArgs e)
        {
            // รับค่า input จากผู้ใช้
            string gender = MaleRadioButton.IsChecked ? "Male" : "Female";
            double weight = double.Parse(weightEntry.Text);
            double heightInCm = double.Parse(heightEntry.Text);

            // แปลงส่วนสูงจากเซนติเมตรเป็นเมตร
            double heightInMeters = heightInCm / 100;

            // คำนวณ BMI
            double bmi = weight / (heightInMeters * heightInMeters);



            // แสดงผลลัพธ์ BMI
            resultLabel.Text = $"ดัชนีมวลกาย (BMI) ของคุณคือ {bmi:F2}\nGender: {gender}";           
        }
    }
}