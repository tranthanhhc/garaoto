using PjGara.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace PjGara
{
    public partial class uc_cars : UserControl
    {
        public uc_cars()
        {
            InitializeComponent();
            // call method to run
            DisplayCarTable();

        }

        public void DisplayCarTable()
        {
            // open the gate to connect
                // connect with variable 
            using(GaraDataEntities1 _entity = new GaraDataEntities1()) {
                // create new datatable 
                List<CarInfo> _carList = new List<CarInfo>();
                // show col in table
                // select all col in table
                _carList = _entity.db_cars.Select(x => new CarInfo
                {
                    CarId= x.CarId,
                    CarCode= x.CarCode,
                    CarName = x.CarName,
                    CarBrand= x.CarBrand,
                    CarModel= x.CarModel,
                    CarOwner= x.CarOwner,
                    CarTime = (DateTime)x.CarTime
                }).ToList();// show form of list
                // new data will show in datagidview with information in new list _carlist
                dgv_cars.DataSource = _carList;
            }
        }
        // add method
        public bool AddCarDetails(db_cars ac)
        {
            bool result = false;
            // new connect
            using(GaraDataEntities1 _entity = new GaraDataEntities1())
            {
                // if new object input == all properties table , add new object
                _entity.db_cars.Add(ac);
                _entity.SaveChanges();
                //when the object true so the result true 
                result = true;
            }
            return result;
        }
        private void btn_CAdd_Click(object sender, EventArgs e)
        {
            try {
                // crate new ob
                db_cars ac = new db_cars();
                ac.CarCode = txt_CCode.Text;
                ac.CarName = txt_CName.Text;
                ac.CarBrand = txt_CTrademark.Text;
                ac.CarModel = cb_CType.SelectedItem.ToString();
                ac.CarOwner = txt_COwner.Text;
                ac.CarTime = (DateTime)dtp_CTime.Value;
                // check ob
                bool result = AddCarDetails(ac);
                if (result == true)
                {
                    MessageBox.Show("Add Successfully!", "Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // display data in dtg;
                    DisplayCarTable();
                    // clear when input done
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Add Unsuccessfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex) {
                MessageBox.Show("CAN'T BE LEFT BLANK : CARCODE ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
        //update method
        private void dgv_cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // need slect record from dgv, this event will take value in rows
            if (dgv_cars.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgv_cars.SelectedRows )
                {
                    txt_CCode.Text = row.Cells[1].Value.ToString();
                     txt_CName.Text = row.Cells[2].Value.ToString();
                    txt_CTrademark.Text = row.Cells[3].Value.ToString();
                    cb_CType.SelectedItem = row.Cells[4].Value.ToString();
                    txt_COwner.Text = row.Cells[5].Value.ToString();
                    dtp_CTime.Value =(DateTime)row.Cells[6].Value;
                }
            }
        }
        public bool UpdateCarDetails(db_cars uc)
        {
            bool result = false;
            using (GaraDataEntities1 _entity = new GaraDataEntities1())
            {
                // need where because can't take if two value != 
               db_cars _car = _entity.db_cars.Where(x => x.CarCode == uc.CarCode).Select(x => x).FirstOrDefault();
                _car.CarName = uc.CarName;
                _car.CarBrand= uc.CarBrand;
                _car.CarOwner= uc.CarOwner;
                _car.CarModel= uc.CarModel;
                _car.CarTime= uc.CarTime;
                _entity.SaveChanges();
                result = true;

            }
            return result;
        }
        private void btn_CUpdate_Click(object sender, EventArgs e)
        {
            try {
                db_cars uc = new db_cars();
                uc.CarCode = txt_CCode.Text;
                uc.CarName = txt_CName.Text;
                uc.CarBrand = txt_CTrademark.Text;
                uc.CarModel = cb_CType.SelectedItem.ToString();
                uc.CarOwner = txt_COwner.Text;
                uc.CarTime = (DateTime)dtp_CTime.Value;

                bool result = UpdateCarDetails(uc);
                try
                {
                    if (result == true)
                    {
                        MessageBox.Show("Update Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayCarTable();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update Unsuccessfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Unsuccessfully!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            } catch(Exception ez)
            {
                MessageBox.Show("Enter at least ONE TextBox", "NEED INPUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }
        //delete method
        public bool DeleteCarDetails(String id)
        {
            bool result = false;
            try
            {
                using (GaraDataEntities1 _entity = new GaraDataEntities1())
                {
                    db_cars _car = _entity.db_cars.Find(id);
                    // if finded the id == _car , handle remove 
                    if(_car != null)
                    {
                        _entity.db_cars.Remove(_car);
                        _entity.SaveChanges();
                        result = true;
                    } else
                    {
                        result= false;
                    }

                }
            }catch
            {
                result= false;
            }
            
            return result;
        }
        private void btn_PDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // id car is the main key, so use Carcode to check 
                String idCar = txt_CCode.Text;
                bool result = DeleteCarDetails(idCar);
                if (result == true)
                {
                    MessageBox.Show("Delete Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCarTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Delete Unsuccessfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr: "+ ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        // clearFields method
        public void ClearFields()
        {
            
            txt_CCode.Clear();
            txt_CName.Clear();
            txt_COwner.Clear();
            txt_CTrademark.Clear();
            cb_CType.SelectedItem = null;
            dtp_CTime.Value = DateTime.Now;
            // after check or st , will set all input return start
            txt_CCode.Enabled = true;
            txt_CName.Enabled = true;
            txt_COwner.Enabled = true;
            txt_CTrademark.Enabled = true;
            cb_CType.Enabled = true;
            dtp_CTime.Enabled = true;
            btn_CAdd.Enabled = true;

        }
        private void btn_ClearInput_Click(object sender, EventArgs e)
        {
            DisplayCarTable();
            ClearFields();
        }
        //seach button
        private void btn_CSearch_Click(object sender, EventArgs e)
        {
            using(GaraDataEntities1 _entity = new GaraDataEntities1())
            {
                // disable Ctime because dont support to find, disable CarCode because CarCode just only
                dtp_CTime.Enabled = false;
                txt_CCode.Enabled = false;
                try
                {    // crate new list to show            
                    List<db_cars> _carList = new List<db_cars>();
                    // if text of txt not null or space 
                    if (txt_CTrademark.Text != null ) {
                        // check value table with input after show list 
                        _carList = _entity.db_cars.Where(x => x.CarBrand.Contains(txt_CTrademark.Text)).Select(x => x).ToList();
                        dgv_cars.DataSource = _carList;
                    }
                    if (txt_CName.Text != null)
                    {
                        _carList = _entity.db_cars.Where(x => x.CarName.Contains(txt_CName.Text)).Select(x => x).ToList();
                        dgv_cars.DataSource = _carList;
                    }
                    if (txt_COwner.Text != null)
                    {
                        _carList = _entity.db_cars.Where(x => x.CarOwner.Contains(txt_COwner.Text)).Select(x => x).ToList();
                        dgv_cars.DataSource = _carList;
                    }
                    if (cb_CType.SelectedItem!= null)
                    {
                        _carList = _entity.db_cars.Where(x => x.CarModel.Contains(cb_CType.SelectedItem.ToString())).Select(x => x).ToList();
                        dgv_cars.DataSource = _carList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
