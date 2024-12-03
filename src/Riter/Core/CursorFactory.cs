﻿using System.Windows.Media;
using Riter.Core.Enum;

namespace Riter.Core;

public static class CursorFactory
{
    public static Cursor Create(DrawingShape currentShape)
    {
        var dpi = GetDpiSuffix();

        return currentShape switch
        {
            DrawingShape.Rectangle => new Cursor(CursorPaths.RectangleCursor(dpi)),
            DrawingShape.Database => new Cursor(CursorPaths.DatabaseCursor(dpi)),
            DrawingShape.Circle => new Cursor(CursorPaths.CircleCursor(dpi)),
            DrawingShape.Arrow => new Cursor(CursorPaths.ArrowCursor(dpi)),
            DrawingShape.Line => new Cursor(CursorPaths.LineCursor(dpi)),
            _ => Cursors.Arrow
        };
    }

    public static Cursor CreateMoveCursor()
    {
        var dpi = GetDpiSuffix();
        return new Cursor(CursorPaths.MoveCursor(dpi));
    }

    private static string GetDpiSuffix()
    {
        var dpiScale = VisualTreeHelper.GetDpi(Application.Current.MainWindow);
        return dpiScale.PixelsPerDip > 1.5 ? "l" : "m";
    }
}
