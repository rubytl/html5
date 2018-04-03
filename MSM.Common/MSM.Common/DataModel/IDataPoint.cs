#region Header

// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Eltek AS" file="IDataPoint.cs">
//   (c) Copyright 2010-2015 Eltek AS
// </copyright>
// <summary>
//   IDataPoint
//   $Revision: 1$
//   $Author: shzhno$
//   $Archive $
//   $Date: 19. august 2016 10:45:52$
//   $Modtime: 19. august 2016 10:27:43$
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#endregion Header

namespace DataModel.DataPoints
{
    using System;
    using System.Net;


    using System.Collections.Generic;

    public interface IDataPoint
    {
        #region Properties

        List<DataPointDef> Items { get; set; }

        #endregion
        #region Methods

        #endregion Methods
    }
}