using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlertCrawl
{
    /// <summary>
    /// Implements Win32 API calls.
    /// </summary>
    internal static class WinApi
    {
        /// <summary>
        /// Scrolls the contents of a window.
        /// </summary>
        /// <param name="hWnd">Handle to the window where the client area is to be scrolled.</param>
        /// <param name="dx">Specifies the amount, in device units, of horizontal scrolling. This parameter must be a negative value to scroll to the left.</param>
        /// <param name="dy">Specifies the amount, in device units, of vertical scrolling. This parameter must be a negative value to scroll up.</param>
        /// <param name="prcScroll">Pointer to a RECT structure that specifies the portion of the client area to be scrolled. If this parameter is NULL, the entire client area is scrolled.</param>
        /// <param name="prcClip">Pointer to a RECT structure that contains the coordinates of the clipping rectangle. Only device bits within the clipping rectangle are affected. Bits scrolled from the outside of the rectangle to the inside are painted; bits scrolled from the inside of the rectangle to the outside are not painted. This parameter may be NULL.</param>
        /// <param name="hrgnUpdate">Handle to the region that is modified to hold the region invalidated by scrolling. This parameter may be NULL.</param>
        /// <param name="prcUpdate">Pointer to a RECT structure that receives the boundaries of the rectangle invalidated by scrolling. This parameter may be NULL.</param>
        /// <param name="flags">Specifies flags that control scrolling.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int ScrollWindowEx(IntPtr hWnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);

        // <summary>
        /// Scroll children within *lprcScroll.
        /// </summary>
        public const uint SW_SCROLLCHILDREN = 0x0001;

        /// <summary>
        /// Invalidate after scrolling.
        /// </summary>
        public const uint SW_INVALIDATE = 0x0002;

        /// <summary>
        /// If SW_INVALIDATE, don't send WM_ERASEBACKGROUND.
        /// </summary>
        public const uint SW_ERASE = 0x0004;

        /// <summary>
        /// Use smooth scrolling.
        /// </summary>
        public const uint SW_SMOOTHSCROLL = 0x0010;
    }
}
