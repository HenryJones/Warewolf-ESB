using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Infragistics.Controls.Charts.Util;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Infragistics.Controls.Charts
{
    /// <summary>
    /// Represents one part of a StackedAreaSeries.
    /// </summary>
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public class AreaFragment : FragmentBase
    {
        #region Constructor and Initalisation
        /// <summary>
        /// Initializes a new instance of the AreaSeries class. 
        /// </summary>
        internal AreaFragment()
        {
            DefaultStyleKey = typeof(AreaFragment);
        }

        #endregion

        #region View-related
        /// <summary>
        /// Called to create the view for the series.
        /// </summary>
        /// <returns>The created view.</returns>
        protected override SeriesView CreateView()
        {
            return new AreaFragmentView(this);
        }
        internal AreaFragmentView AreaFragmentView { get; set; }
        /// <summary>
        /// Called when the view for the series is created.
        /// </summary>
        /// <param name="view">The created view.</param>
        protected internal override void OnViewCreated(SeriesView view)
        {
            base.OnViewCreated(view);
            AreaFragmentView = (AreaFragmentView)view;
        }
        #endregion

        internal override CategoryMode PreferredCategoryMode(CategoryAxisBase axis)
        {
            return CategoryMode.Mode0;
        }
        /// <summary>
        /// Clears the rendering for the series.
        /// </summary>
        /// <param name="wipeClean">True if the cached visuals should also be cleared.</param>
        /// <param name="view">The SeriesView in context.</param>
        protected internal override void ClearRendering(bool wipeClean, SeriesView view)
        {
            base.ClearRendering(wipeClean, view);

            var areaFragmentView = (AreaFragmentView)view;
            areaFragmentView.ClearRendering();
        }

        internal override void RenderFrame(CategoryFrame frame, CategorySeriesView view)
        {
            base.RenderFrame(frame, view);

            Func<int, double> x0 = delegate(int i) { return frame.Buckets[i][0]; };
            Func<int, double> y0 = delegate(int i) { return frame.Buckets[i][1]; };
            Func<int, double> x1 = delegate(int i) { return frame.Buckets[i][0]; };
            Func<int, double> y1 = delegate(int i) { return frame.Buckets[i][2]; };

            //Make the rasterizer aware of the possible date time axis
            LineRasterizer.IsSortingAxis = XAxis is ISortingAxis ? true : false;

            AreaFragmentView areaView = view as AreaFragmentView;

            int bucketSize = areaView.BucketCalculator.BucketSize;
            LineRasterizer.RasterizePolygonPaths(areaView.polygon0, areaView.polyline0, areaView.polygon1, areaView.polyline1, frame.Buckets.Count, x0, y0, x1, y1, bucketSize, Resolution, (p0, l0, p01, l1, f) => TerminatePolygon(p0, x0, y1, view), UnknownValuePlotting.LinearInterpolate);
        }

    }
}

#region Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved
/* ---------------------------------------------------------------------*
*                           Infragistics, Inc.                          *
*              Copyright (c) 2001-2012 All Rights reserved               *
*                                                                       *
*                                                                       *
* This file and its contents are protected by United States and         *
* International copyright laws.  Unauthorized reproduction and/or       *
* distribution of all or any portion of the code contained herein       *
* is strictly prohibited and will result in severe civil and criminal   *
* penalties.  Any violations of this copyright will be prosecuted       *
* to the fullest extent possible under law.                             *
*                                                                       *
* THE SOURCE CODE CONTAINED HEREIN AND IN RELATED FILES IS PROVIDED     *
* TO THE REGISTERED DEVELOPER FOR THE PURPOSES OF EDUCATION AND         *
* TROUBLESHOOTING. UNDER NO CIRCUMSTANCES MAY ANY PORTION OF THE SOURCE *
* CODE BE DISTRIBUTED, DISCLOSED OR OTHERWISE MADE AVAILABLE TO ANY     *
* THIRD PARTY WITHOUT THE EXPRESS WRITTEN CONSENT OF INFRAGISTICS, INC. *
*                                                                       *
* UNDER NO CIRCUMSTANCES MAY THE SOURCE CODE BE USED IN WHOLE OR IN     *
* PART, AS THE BASIS FOR CREATING A PRODUCT THAT PROVIDES THE SAME, OR  *
* SUBSTANTIALLY THE SAME, FUNCTIONALITY AS ANY INFRAGISTICS PRODUCT.    *
*                                                                       *
* THE REGISTERED DEVELOPER ACKNOWLEDGES THAT THIS SOURCE CODE           *
* CONTAINS VALUABLE AND PROPRIETARY TRADE SECRETS OF INFRAGISTICS,      *
* INC.  THE REGISTERED DEVELOPER AGREES TO EXPEND EVERY EFFORT TO       *
* INSURE ITS CONFIDENTIALITY.                                           *
*                                                                       *
* THE END USER LICENSE AGREEMENT (EULA) ACCOMPANYING THE PRODUCT        *
* PERMITS THE REGISTERED DEVELOPER TO REDISTRIBUTE THE PRODUCT IN       *
* EXECUTABLE FORM ONLY IN SUPPORT OF APPLICATIONS WRITTEN USING         *
* THE PRODUCT.  IT DOES NOT PROVIDE ANY RIGHTS REGARDING THE            *
* SOURCE CODE CONTAINED HEREIN.                                         *
*                                                                       *
* THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.              *
* --------------------------------------------------------------------- *
*/
#endregion Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved