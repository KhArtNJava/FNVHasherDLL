﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FNVHasherDLL;
using System.Numerics;
using System.Globalization;
using System.Diagnostics;

namespace FNVHasherDLLTestEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            this.Text = this.Text + ", Version " + version;

            calc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void calc()
        {
            //Hex
            {

                fnv64highbitHex.Text = FNVHasherStrFunctions.fnv64HighBitHexString(textToEncode.Text);
                fnv64Hex.Text = FNVHasherStrFunctions.fnv64HexString(textToEncode.Text);

                fnv32HighBitHex.Text = FNVHasherStrFunctions.fnv32HighBitHexString(textToEncode.Text);
                fnv32Hex.Text = FNVHasherStrFunctions.fnv32HexString(textToEncode.Text);

                fnv24Hex.Text = FNVHasherStrFunctions.fnv24HexString(textToEncode.Text);
            }

            //Decimal
            {

                fnv64highbitDecimal.Text = FNVHasherStrFunctions.fnv64HighBitDecimal(textToEncode.Text).ToString();
                fnv64Decimal.Text = FNVHasherStrFunctions.fnv64Decimal(textToEncode.Text).ToString();

                fnv32HighBitDecimal.Text = FNVHasherStrFunctions.fnv32HighBitDecimal(textToEncode.Text).ToString();
                fnv32Decimal.Text = FNVHasherStrFunctions.fnv32Decimal(textToEncode.Text).ToString();

                fnv24Decimal.Text = FNVHasherStrFunctions.fnv24Decimal(textToEncode.Text).ToString();
            }


        }

        private void fnv64highbitHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv64highbitHex.Text);
            MessageBox.Show("Copied to clipboard!");

        }

        private void fnv64Hex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv64Hex.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv32HighBitHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv32HighBitHex.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv32Hex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv32Hex.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv24_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv24Hex.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv64highbitDecimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv64highbitDecimal.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv64Decimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv64Decimal.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv32HighBitDecimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv32HighBitDecimal.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv32Decimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv32Decimal.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void fnv24Decimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fnv24Decimal.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void convertedValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(convertedValue.Text);
            MessageBox.Show("Copied to clipboard!");
        }

        private void valueToConvert_TextChanged(object sender, EventArgs e)
        {
            if (valueToConvert.Text.StartsWith("0x") ||
                valueToConvert.Text.StartsWith("0X"))
            {
                BigInteger r = FNVHasherStrFunctions.hexToDecimal(valueToConvert.Text);
                convertedValue.Text = r.ToString();
            }
            else
            {
                convertedValue.Text = FNVHasherStrFunctions.decimalToHex(valueToConvert.Text);
            }
        }
    }
}
