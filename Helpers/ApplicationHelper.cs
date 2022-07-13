
using System;
using System.Collections.Generic;
using System.IO;

namespace smk_travel.Helpers;

public class ApplicationHelper
{
    public static string RenderHtmlFile(string file, int width)
    {
        var html = string.Empty;
        var extencao = Path.GetExtension(file).ToLower();
        var extencoesPermitidas = new List<string>() {".jpg", ".jpeg", ".png", ".bitmap", ".bmp", ".gif", "", ".webp"};
        if(extencoesPermitidas.Contains(extencao))
            html = $"<img src=\"{file}\" style=\"width: {width}px;\">";
        else
            html = file;
        return html;
    }
}