﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace EHR_Hospital
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        //public int InsertSupplier(string snum, string sname, string city, int status)
        //{
        //    string query = "INSERT INTO S (S#, Name, City, Status) " +
        //                    "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public DataTable GetRelativesChronic(string id)
        {
            string query = "SELECT Patient.Fname, Patient.Lname, ChronicDiseases.Disease FROM Patient, ChronicDiseases WHERE Patient.NationalID IN (SELECT Relatives.Relative_ID From Relatives WHERE Relatives.Patient_ID = '" + id + "' AND Accepted = 1) AND ChronicDiseases.PatientID = Patient.NationalID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetHospital(string username, string password)
        {
            string query = "SELECT * " +
                "From Hospital " +
                "Where Username = '" + username + "' and Password = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertLabTest(string patient_id, string date, string description)
        {
            string query = "Insert into Lab_Results(Patient_ID, Date_Time, Description) values ('" + patient_id + "', '" +date+ "', '"+description+"')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int IDExist(string id)
        {
            string query = "SELECT COUNT(NationalID) FROM Patient WHERE NationalID = '" + id + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int EmailExist(string email)
        {
            string query = "SELECT COUNT(Email) FROM Patient WHERE Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int InsertDiagnosis(int HospitalID, string PatientID, string Date, string Diagnosis, string Symptoms, int Prescription_ID) //complex query
        {
            string storedprocedurenames = StoredProcedures.InsertDiag;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@HosID", HospitalID);
            Parameters.Add("@patID", PatientID);
            Parameters.Add("@Date", Date);
            Parameters.Add("@Diag", Diagnosis);
            Parameters.Add("@symp", Symptoms);
            Parameters.Add("@presID", Prescription_ID);
            return dbMan.ExecuteNonQuery(storedprocedurenames, Parameters);

        }
        public DataTable getlabtests()
        {
            string query = "SELECT * FROM Lab_Tests";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getsurgeriestypes()
        {
            string query = "SELECT * FROM Surguries";
            return dbMan.ExecuteReader(query);
        }

        public DataTable InsertPrescription(string Date)
        {
            string query = "INSERT INTO Prescription(Date_Time) VALUES ('" + Date + "')" +
                " Select @@IDENTITY AS [@@IDENTITY];";
            return dbMan.ExecuteReader(query);
        }
        public int Updatetodead(string id)
        {
            string query = "UPDATE Patient Set DeadOrAlive=1 Where NationalID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetWaiting()
        {
            string query = "SELECT * FROM Organ_Waiting_List WHERE Status = 0 ORDER BY Priority desc"; //assuming 0 means status
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDonate()
        {
            string query = "SELECT * FROM Organ_Donor"; //assuming 0 means status
            return dbMan.ExecuteReader(query);
        }

        public DataTable getpatient(string id)
        {
            string query = "SELECT * FROM Patient WHERE NationalID='" + id + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetPrescriptionID(string Date)
        {
            string query = "Select Prescription_ID FROM Prescription WHERE Date_Time = '" + Date + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertMedications(int PresID, string Medication, int qnty)
        {
            string query = "Insert INTO Medications Values ("+PresID+",'"+Medication+"',"+qnty+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetHospital(string username)
        {
            string query = "SELECT Hospital_ID " +
                "From Hospital " +
                "Where Username = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertOrganWaiting(string organ, string patientid, int priority, int HospitalID, int status, string date)
        {
            string query = "INSERT INTO Organ_Waiting_List VALUES ('" + organ + "','" + patientid + "'," + priority + ", "+HospitalID+","+status+",'"+date+"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetChronic(string PatientID)
        {
            string query = "Select Disease FROM ChronicDiseases WHERE PatientID = '"+PatientID+"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDiagnosis(string PatientID)
        {
            string query = "Select Date_Time, Diagnosis, Symptoms FROM Diagnosis WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPrescriptions(string PatientID) //complex query
        {
            string query = "Select Prescription.Date_Time, Medications.Medication, Prescription.Given_or_not FROM Prescription, Diagnosis, Medications WHERE Patient_ID = '" + PatientID + "' AND Diagnosis.Prescription_ID = Prescription.Prescription_ID AND Prescription.Prescription_ID = Medications.Prescription_ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSurgeries(string PatientID)
        {
            string query = "Select Date_Time, Type_of_Surgery, Surgery_Report FROM Surgery WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetLabs(string PatientID)
        {
            string query = "Select Date_Time, Test_Result FROM Lab_Results WHERE Patient_ID = '" + PatientID + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getifDonor(string patientID)
        {
            string query = "SELECT Organ_Donor_Upon_Death FROM Patient WHERE NationalID = '" + patientID + "'";
            return dbMan.ExecuteReader(query);
        }

        public int InsertOrganDonor(string organ, string pid, int status)
        {
            string query = "INSERT INTO Organ_Donor VALUES ('" + organ + "','" + pid + "'," + status + ");";
            return dbMan.ExecuteNonQuery(query); 
        }

        public int DeleteFromOrganDonor(string patientID)
        {
            string storedprocedurenames = StoredProcedures.DELETEORGAN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@patID", patientID);
            return dbMan.ExecuteNonQuery(storedprocedurenames, Parameters);
        }

        public int InsertIntoSurgery(string PatientID, int HospitalID, string Report, string Date, string Type)
        {
            string query = "INSERT INTO Surgery(Patient_ID, Hospital_ID, Surgery_Report, Date_Time, Type_of_Surgery) VALUES ('"+PatientID+"',"+HospitalID+",'"+Report+"','" + Date + "','" + Type + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getMedicationList()
        {
            string query = "SELECT * FROM Drugs ORDER BY Trade_Name ASC";
            return dbMan.ExecuteReader(query);
        }

        public int ChangePass(string id, string pass)
        {
            string query = "UPDATE Hospital SET Password = '" + pass + "' WHERE Name = '" + id + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getdiseases()
        {
            string query = "SELECT * FROM Diseases";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateStatus(string pid, string organ)
        {
            string query = "UPDATE Organ_Waiting_List SET Status = 1 WHERE Organ_Required = '" + organ + "' AND Patient_ID = '" + pid + "' AND Status = 0;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteDonor(string pid, string organ)
        {
            string query = "DELETE FROM Organ_Donor WHERE Donor_ID = '" + pid + "' AND Organ_Type = '" + organ+"';";
            return dbMan.ExecuteNonQuery(query);
        }


        //public int DeleteSupplier(string snum)
        //{
        //    string query = "DELETE FROM S WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int UpdateSupplier(string snum, string city)
        //{
        //    string query = "UPDATE S SET City='" + city + "' WHERE S#='" + snum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectAllSuppliers()
        //{
        //    string query = "SELECT * FROM S;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int CountSuppliers()
        //{
        //    string query = "SELECT COUNT(S#) FROM S;";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

