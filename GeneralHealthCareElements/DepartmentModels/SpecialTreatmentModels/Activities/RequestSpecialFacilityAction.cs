﻿using GeneralHealthCareElements.Activities;
using GeneralHealthCareElements.Entities;
using GeneralHealthCareElements.GeneralClasses.ActionTypesAndPaths;
using GeneralHealthCareElements.ResourceHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralHealthCareElements.SpecialFacility
{
    /// <summary>
    /// Request of an special service action, has no own functionality but prevents too much
    /// casting in rule definitions of control units
    /// </summary>
    public class RequestSpecialFacilityAction : RequestHealthCareAction<SpecialServiceActionTypeClass>
    {
        #region Constructor

        public RequestSpecialFacilityAction(EntityPatient patient,
            double degreeOfCompletion,
            SpecialServiceActionTypeClass actionType,
            DateTime time,
            ResourceSet resources)
            : base(patient, degreeOfCompletion, actionType, time, resources)
        {
            _actionType = actionType;
        } // end of RequestDiagnosticTreatment

        #endregion

        //--------------------------------------------------------------------------------------------------
        // Attributes 
        //--------------------------------------------------------------------------------------------------

        #region ActionType

        private SpecialServiceActionTypeClass _actionType;

        public SpecialServiceActionTypeClass ActionType
        {
            get
            {
                return _actionType;
            }
            set
            {
                _actionType = value;
            }
        } // end of ActionType

        #endregion

    } // end of RequestDiagnosticTreatment
}
