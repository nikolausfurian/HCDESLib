﻿using GeneralHealthCareElements.Entities;
using SimulationCore.HCCMElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralHealthCareElements.StaffHandling
{
    /// <summary>
    /// Request that a staff member files when he goes out of shift
    /// </summary>
    public class RequestBeAbsent : ActivityRequest
    {
        #region Constructor

        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="staffMember">The staff member filing the request</param>
        /// <param name="time">Time the request is filed</param>
        public RequestBeAbsent(EntityHealthCareStaff staffMember, DateTime time)
            :base("ActivityBeAbsent", staffMember.ToArray(), time)
        {
            _staffMember = staffMember;
        } // end of RequestBeAbsent

        #endregion

        //--------------------------------------------------------------------------------------------------
        // Member 
        //--------------------------------------------------------------------------------------------------

        #region StaffMember

        private EntityHealthCareStaff _staffMember;

        /// <summary>
        /// The staff member filing the request
        /// </summary>
        public EntityHealthCareStaff StaffMember
        {
            get
            {
                return _staffMember;
            }
        } // end of StaffMember

        #endregion

    } // end of RequestBeAbsent
}
