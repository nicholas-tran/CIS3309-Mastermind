// Jimmy Pham & Nicholas Tran
// Mastermind Project
// April 11, 2018 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tran_CIS3309_Mastermind
{
    class currentFileClass
    {
        private string currentFilePath;
        private System.IO.StreamReader currentFileSR;
        private int recordReadCount;
 
        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public currentFileClass
            (string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Cannot open file" + currentFilePath + "Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end currentFileClass Constructor 



        // Read a record from the current file
        // Returns: the text string read and (through an output argument) a true-false 
        //          indicator for end-of-file
        public string getNextRecord(
            ref Boolean endOfFileFlag)
        {
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            } // end if

            return (nextRecord);
        } // end getNextRecord



        // Get value of number of records read
        public int getRecordsReadCount()
        {
            return recordReadCount;
        } // end getRecordsReadCount



        // Close the input file
        public void closeFile()
        {
            currentFileSR.Close();
        }  // end closeFile


        // Rewind the input file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR = new System.IO.StreamReader(currentFilePath);
            currentFileSR.DiscardBufferedData();
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }  // end rewindFile

    } // end currentFileClass
} // end namespace

