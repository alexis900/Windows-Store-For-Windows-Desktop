'747
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.TextBox1.Text = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B3152A74F-5BAF-74F5-5D65-86E19C4B2B06%7D%26lang%3Des%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers/update2/installers/ChromeSetup.exe"
        Form2.TextBox2.Text = "C:\Downloads\ChromeSetup.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = "https://download.mozilla.org/?product=firefox-stub&os=win&lang=es-ES"
        Form2.TextBox2.Text = "C:\Downloads\Firefox Setup Stub Lastest.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub UneditURLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.TextBox1.Text = "http://www.skype.com/go/getskype"
        Form2.TextBox2.Text = "C:\Downloads\SkypeSetupFull.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.TextBox1.Text = "http://dl.maxthon.com/online_install/mx4/mxsetup.exe"
        Form2.TextBox2.Text = "C:\Downloads\mxsetup.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.TextBox1.Text = "http://sdlc-esd.sun.com/ESD6/JSCDL/jdk/7u67-b01/jre-7u67-windows-i586.exe?AuthParam=1407707359_623b0582e6a06d423eb82ad4c517b95f&GroupName=JSC&FilePath=/ESD6/JSCDL/jdk/7u67-b01/jre-7u67-windows-i586.exe&File=jre-7u67-windows-i586.exe&BHost=javadl.sun.com"
        Form2.TextBox2.Text = "C:\Downloads\jre-7u67-windows-i586.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.TextBox1.Text = "http://sdlc-esd.sun.com/ESD6/JSCDL/jdk/7u67-b01/jre-7u67-windows-x64.exe?AuthParam=1407707422_789e34a2ca3c0e85712537b8dc5ffef2&GroupName=JSC&FilePath=/ESD6/JSCDL/jdk/7u67-b01/jre-7u67-windows-x64.exe&File=jre-7u67-windows-x64.exe&BHost=javadl.sun.com"
        Form2.TextBox2.Text = "C:\Downloads\jre-7u67-windows-x64.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.TextBox1.Text = "http://aihdownload.adobe.com/bin/live/install_flashplayer14x32_mssd_aaa_aih.exe"
        Form2.TextBox2.Text = "C:\Downloads\install_flashplayer14x32_mssd_aaa_aih.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form2.TextBox1.Text = "http://download.gimp.org/pub/gimp/v2.8/windows/gimp-2.8.14-setup-1.exe"
        Form2.TextBox2.Text = "C:\Downloads\gimp-2.8.14-setup-1.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.TextBox1.Text = "http://software-files-a.cnet.com/s/software/13/80/04/01/avast_free_antivirus_setup_online.exe?token=1406590416_639ae122202c0e04219a93ba03e861ea&fileName=avast_free_antivirus_setup_online.exe"
        Form2.TextBox2.Text = "C:\Downloads\avast_free_antivirus_setup_online.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form2.TextBox1.Text = "http://donate.libreoffice.org/home/dl/win-x86/4.3.2/es/LibreOffice_4.3.2_Win_x86.msi"
        Form2.TextBox2.Text = "C:\Downloads\LibreOffice_4.3.2_Win_x86.msi"
        Form2.ShowDialog()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form2.TextBox1.Text = "http://www.dotpdn.com/files/paint.net.4.0.3.install.zip"
        Form2.TextBox2.Text = "C:\Downloads\paint.net.4.0.3.install.zip"
        Form2.ShowDialog()
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form2.TextBox1.Text = "https://sourceforge.net/projects/sevenzip/files/7-Zip/9.22/7z922.exe/download"
        Form2.TextBox2.Text = "C:\Downloads\7z922.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub NewVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUpdatesToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/windowsstoreforwindowsdesktop/files/ALPHA/0013.exe/download")
        Catch
            'Code to hanle the error
        End Try
    End Sub
    '//Translations
    Private Sub SpanishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanishToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Store para el escritorio de Windows"
        'Descargar'
        Button1.Text = "Descargar"
        Button2.Text = "Descargar"
        Button3.Text = "Descargar"
        Button5.Text = "Descargar"
        Button7.Text = "Descargar"
        Button8.Text = "Descargar"
        Button9.Text = "Descargar"
        Button10.Text = "Descargar"
        Button13.Text = "Descargar"
        Button14.Text = "Descargar"
        Button11.Text = "Descargar"
        Button12.Text = "Descargar"
        Button16.Text = "Descargar"
        Button17.Text = "Descargar"
        Button18.Text = "Descargar"
        Button19.Text = "Descargar"
        Button20.Text = "Descargar"
        Button21.Text = "Descargar"
        Button22.Text = "Descargar"
        Button23.Text = "Descargar"
        Button24.Text = "Descargar"
        Button25.Text = "Descargar"
        'Categorias'
        Button4.Text = "Navegadores Web"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Ajustes"
        ToolStripMenuItem2.Text = "Acerca de..."
        ToolStripMenuItem3.Text = "Salir"
        OpenDownloaderToolStripMenuItem.Text = "Descargador"
        TranslatorToolStripMenuItem.Text = "Traductor"
        EnglishToolStripMenuItem.Text = "Inglés"
        SpanishToolStripMenuItem.Text = "Español"
        CatalanToolStripMenuItem.Text = "Catalán"
        GaliciaToolStripMenuItem.Text = "Gallego"
        PortugeseToolStripMenuItem.Text = "Portugués"
        CheckUpdatesToolStripMenuItem.Text = "Buscar actualizaciones"
        ''Form 2''
        Form2.Text = "Descargador"
        Form2.Button1.Text = "Descargar"
        Form2.Label2.Text = "Directorio"
        Form2.MenuToolStripMenuItem.Text = "Ajustes"
        Form2.EditURLToolStripMenuItem.Text = "Editar URL"
        Form2.UneditURLToolStripMenuItem.Text = "Dejar de editar la URL"
        Form2.Button4.Text = "Abrir"
        Form2.Button3.Text = "Abrir"
        ''Web Browsers''
        webbrowsers.Button1.Text = "Descargar"
        webbrowsers.Button2.Text = "Descargar"
        ''About that...''
        AboutThis.Text = "Acerca de..."
        ''AboutThis
        AboutThis.Button1.Text = "Activar modo de desarrollo"
        AboutThis.Button2.Text = "Desactivar modo de desarrollo"
        AboutThis.Label1.Text = "Este programa no pretende fomentar la piratería"
        'Post
        post.Button1.Text = "Descargar"
        post.Button2.Text = "Descargar"
        post.Button3.Text = "Descargar"
        post.Button7.Text = "Descargar"
        post.Button8.Text = "Descargar"
        post.Button9.Text = "Descargar"
        post.Button11.Text = "Descargar"
        post.Button12.Text = "Descargar"
        post.Button14.Text = "Descargar"
        post.Button16.Text = "Descargar"
        post.Button17.Text = "Descargar"
        post.Button19.Text = "Descargar"
        post.Button23.Text = "Descargar"
        post.Button24.Text = "Descargar"
        post.Button25.Text = "Descargar"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Descargar"
        ubuntu.Button2.Text = "Descargar"
        ubuntu.Button3.Text = "Descargar"
        ubuntu.Button4.Text = "Descargar"
        ubuntu.Button5.Text = "Descargar"
        ubuntu.Button6.Text = "Descargar"
        ubuntu.Button7.Text = "Descargar"
        ubuntu.Button8.Text = "Descargar"
        ubuntu.Button9.Text = "Descargar"
        ubuntu.Button10.Text = "Descargar"
        ubuntu.Button11.Text = "Descargar"
        ubuntu.Button12.Text = "Descargar"
        'android
        androidx86.Button1.Text = "Descargar"
        androidx86.Button2.Text = "Descargar"
        androidx86.Button3.Text = "Descargar"
        androidx86.Button4.Text = "Descargar"
        androidx86.Button5.Text = "Descargar"
        androidx86.Button6.Text = "Descargar"
        androidx86.Button7.Text = "Descargar"
        androidx86.Button8.Text = "Descargar"
        androidx86.Button9.Text = "Descargar"
        androidx86.Button10.Text = "Descargar"
        androidx86.Button11.Text = "Descargar"
        androidx86.Button12.Text = "Descargar"
        androidx86.Button13.Text = "Descargar"
        androidx86.Button14.Text = "Descargar"
        androidx86.Button15.Text = "Descargar"
        'linux distros
        ld.Button1.Text = "Versión"
        ld.Button2.Text = "Descargar"
        ld.Button3.Text = "Descargar"
        ld.Button12.Text = "Versión"
    End Sub
    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Store For Windows Desktop"
        'Descargar'
        Button1.Text = "Download"
        Button2.Text = "Download"
        Button3.Text = "Download"
        Button5.Text = "Download"
        Button7.Text = "Download"
        Button8.Text = "Download"
        Button9.Text = "Download"
        Button10.Text = "Download"
        Button13.Text = "Download"
        Button14.Text = "Download"
        Button11.Text = "Download"
        Button12.Text = "Download"
        Button16.Text = "Download"
        Button17.Text = "Download"
        Button18.Text = "Download"
        Button19.Text = "Download"
        Button20.Text = "Download"
        Button21.Text = "Download"
        Button22.Text = "Download"
        Button23.Text = "Download"
        Button24.Text = "Download"
        Button25.Text = "Download"
        'Categorias'
        Button4.Text = "Web Browser"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Settings"
        ToolStripMenuItem2.Text = "About that..."
        ToolStripMenuItem3.Text = "Exit"
        OpenDownloaderToolStripMenuItem.Text = "Downloader"
        TranslatorToolStripMenuItem.Text = "Translator"
        EnglishToolStripMenuItem.Text = "English"
        SpanishToolStripMenuItem.Text = "Spanish"
        CatalanToolStripMenuItem.Text = "Catalan"
        GaliciaToolStripMenuItem.Text = "Galician"
        PortugeseToolStripMenuItem.Text = "Portugese"
        CheckUpdatesToolStripMenuItem.Text = "Check Updates"

        ''Form 2''
        Form2.Text = "Downloader"
        Form2.Button1.Text = "Download"
        Form2.Label2.Text = "Directory"
        Form2.MenuToolStripMenuItem.Text = "Settings"
        Form2.EditURLToolStripMenuItem.Text = "Edit URL"
        Form2.UneditURLToolStripMenuItem.Text = "Unedit URL"
        Form2.Button4.Text = "Open"
        Form2.Button3.Text = "Open"
        ''Web Browsers''
        webbrowsers.Button1.Text = "Downloads"
        webbrowsers.Button2.Text = "Downloads"
        ''About that...''
        AboutThis.Text = "About that..."
        ''AboutThis
        AboutThis.Button1.Text = "Activate the developer Mode"
        AboutThis.Button2.Text = "Deactivate the developer Mode"
        AboutThis.Label1.Text = "This software doesn't attempt to encourage piracy"

        'Post
        post.Button1.Text = "Download"
        post.Button2.Text = "Download"
        post.Button3.Text = "Download"
        post.Button7.Text = "Download"
        post.Button8.Text = "Download"
        post.Button9.Text = "Download"
        post.Button11.Text = "Download"
        post.Button12.Text = "Download"
        post.Button14.Text = "Download"
        post.Button16.Text = "Download"
        post.Button17.Text = "Download"
        post.Button19.Text = "Download"
        post.Button23.Text = "Download"
        post.Button24.Text = "Download"
        post.Button25.Text = "Download"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Download"
        ubuntu.Button2.Text = "Download"
        ubuntu.Button3.Text = "Download"
        ubuntu.Button4.Text = "Download"
        ubuntu.Button5.Text = "Download"
        ubuntu.Button6.Text = "Download"
        ubuntu.Button7.Text = "Download"
        ubuntu.Button8.Text = "Download"
        ubuntu.Button9.Text = "Download"
        ubuntu.Button10.Text = "Download"
        ubuntu.Button11.Text = "Download"
        ubuntu.Button12.Text = "Download"
        'android
        androidx86.Button1.Text = "Download"
        androidx86.Button2.Text = "Download"
        androidx86.Button3.Text = "Download"
        androidx86.Button4.Text = "Download"
        androidx86.Button5.Text = "Download"
        androidx86.Button6.Text = "Download"
        androidx86.Button7.Text = "Download"
        androidx86.Button8.Text = "Download"
        androidx86.Button9.Text = "Download"
        androidx86.Button10.Text = "Download"
        androidx86.Button11.Text = "Download"
        androidx86.Button12.Text = "Download"
        androidx86.Button13.Text = "Download"
        androidx86.Button14.Text = "Download"
        androidx86.Button15.Text = "Download"
        'linux distros
        ld.Button1.Text = "Versions"
        ld.Button2.Text = "Download"
        ld.Button3.Text = "Download"
        ld.Button12.Text = "Versions"
    End Sub
    Private Sub CatalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalanToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Store per l'escroptori de Windows"
        'Descargar'
        Button1.Text = "Descarregar"
        Button2.Text = "Descarregar"
        Button3.Text = "Descarregar"
        Button5.Text = "Descarregar"
        Button7.Text = "Descarregar"
        Button8.Text = "Descarregar"
        Button9.Text = "Descarregar"
        Button10.Text = "Descarregar"
        Button13.Text = "Descarregar"
        Button14.Text = "Descarregar"
        Button11.Text = "Descarregar"
        Button12.Text = "Descarregar"
        Button16.Text = "Descarregar"
        Button17.Text = "Descarregar"
        Button18.Text = "Descarregar"
        Button19.Text = "Descarregar"
        Button20.Text = "Descarregar"
        Button21.Text = "Descarregar"
        Button22.Text = "Descarregar"
        Button23.Text = "Descarregar"
        Button24.Text = "Descarregar"
        Button25.Text = "Descarregar"
        'Categorias'
        Button4.Text = "Navegadors Web"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Ajustaments"
        ToolStripMenuItem2.Text = "Sobre..."
        ToolStripMenuItem3.Text = "Sortir"
        OpenDownloaderToolStripMenuItem.Text = "Descarregador"
        TranslatorToolStripMenuItem.Text = "Traductor"
        EnglishToolStripMenuItem.Text = "Anglés"
        SpanishToolStripMenuItem.Text = "Espanyol"
        CatalanToolStripMenuItem.Text = "Català"
        GaliciaToolStripMenuItem.Text = "Gallego"
        PortugeseToolStripMenuItem.Text = "Portuguès"
        CheckUpdatesToolStripMenuItem.Text = "Cerca actualitzacions"
        ''Form 2''
        Form2.Text = "Descarregador"
        Form2.Button1.Text = "Descarregar"
        Form2.Label2.Text = "Directori"
        Form2.MenuToolStripMenuItem.Text = "Ajustaments"
        Form2.EditURLToolStripMenuItem.Text = "Edita URL"
        Form2.UneditURLToolStripMenuItem.Text = "Deixa d'editar l'URL"
        Form2.Button4.Text = "Obrir"
        Form2.Button3.Text = "Obrir"
        ''Web Browsers''
        webbrowsers.Button1.Text = "Descarregar"
        webbrowsers.Button2.Text = "Descarregar"
        ''About that...''
        AboutThis.Text = "Sobre..."
        ''AboutThis
        AboutThis.Button1.Text = "Activa el mode de desenvolupador"
        AboutThis.Button2.Text = "Desctiva el mode de desenvolupador"
        AboutThis.Label1.Text = "Aquest programa no pretén fomentar la pirateria"
        'Post
        post.Button1.Text = "Descarregar"
        post.Button2.Text = "Descarregar"
        post.Button3.Text = "Descarregar"
        post.Button7.Text = "Descarregar"
        post.Button8.Text = "Descarregar"
        post.Button9.Text = "Descarregar"
        post.Button11.Text = "Descarregar"
        post.Button12.Text = "Descarregar"
        post.Button14.Text = "Descarregar"
        post.Button16.Text = "Descarregar"
        post.Button17.Text = "Descarregar"
        post.Button19.Text = "Descarregar"
        post.Button23.Text = "Descarregar"
        post.Button24.Text = "Descarregar"
        post.Button25.Text = "Descarregar"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Descarregar"
        ubuntu.Button2.Text = "Descarregar"
        ubuntu.Button3.Text = "Descarregar"
        ubuntu.Button4.Text = "Descarregar"
        ubuntu.Button5.Text = "Descarregar"
        ubuntu.Button6.Text = "Descarregar"
        ubuntu.Button7.Text = "Descarregar"
        ubuntu.Button8.Text = "Descarregar"
        ubuntu.Button9.Text = "Descarregar"
        ubuntu.Button10.Text = "Descarregar"
        ubuntu.Button11.Text = "Descarregar"
        ubuntu.Button12.Text = "Descarregar"
        'android
        androidx86.Button1.Text = "Descarregar"
        androidx86.Button2.Text = "Descarregar"
        androidx86.Button3.Text = "Descarregar"
        androidx86.Button4.Text = "Descarregar"
        androidx86.Button5.Text = "Descarregar"
        androidx86.Button6.Text = "Descarregar"
        androidx86.Button7.Text = "Descarregar"
        androidx86.Button8.Text = "Descarregar"
        androidx86.Button9.Text = "Descarregar"
        androidx86.Button10.Text = "Descarregar"
        androidx86.Button11.Text = "Descarregar"
        androidx86.Button12.Text = "Descarregar"
        androidx86.Button13.Text = "Descarregar"
        androidx86.Button14.Text = "Descarregar"
        androidx86.Button15.Text = "Descarregar"
        'linux distros
        ld.Button1.Text = "Versions"
        ld.Button2.Text = "Descarregar"
        ld.Button3.Text = "Descarregar"
        ld.Button12.Text = "Versions"
    End Sub
    Private Sub EuskeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EuskeraToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Store egiteko du mahaian of Windows"
        'Descargar'
        Button1.Text = "Jaitsi"
        Button2.Text = "Jaitsi"
        Button3.Text = "Jaitsi"
        Button5.Text = "Jaitsi"
        Button7.Text = "Jaitsi"
        Button8.Text = "Jaitsi"
        Button9.Text = "Jaitsi"
        Button10.Text = "Jaitsi"
        Button13.Text = "Jaitsi"
        Button14.Text = "Jaitsi"
        Button11.Text = "Jaitsi"
        Button12.Text = "Jaitsi"
        Button16.Text = "Jaitsi"
        Button17.Text = "Jaitsi"
        Button18.Text = "Jaitsi"
        Button19.Text = "Jaitsi"
        Button20.Text = "Jaitsi"
        Button21.Text = "Jaitsi"
        Button22.Text = "Jaitsi"
        Button23.Text = "Jaitsi"
        Button24.Text = "Jaitsi"
        Button25.Text = "Jaitsi"
        'Categorias'
        Button4.Text = "Nabigatzaile Web"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Ezarpenak"
        ToolStripMenuItem2.Text = "Buruz of..."
        ToolStripMenuItem3.Text = "Talde"
        OpenDownloaderToolStripMenuItem.Text = "Jatsier"
        TranslatorToolStripMenuItem.Text = "Itzultzaileak"
        EnglishToolStripMenuItem.Text = "English"
        SpanishToolStripMenuItem.Text = "Espainiako"
        CatalanToolStripMenuItem.Text = "Catalan"
        GaliciaToolStripMenuItem.Text = "Gallego"
        PortugeseToolStripMenuItem.Text = "Portugesa"
        CheckUpdatesToolStripMenuItem.Text = "bilatu nahi eguneratzerik"
        ''Form 2''
        Form2.Text = "Downloader"
        Form2.Button1.Text = "Jaitsi"
        Form2.Label2.Text = "Directory"
        Form2.MenuToolStripMenuItem.Text = "Ezarpenak"
        Form2.EditURLToolStripMenuItem.Text = "Editatu URL"
        Form2.UneditURLToolStripMenuItem.Text = "Utlzi of editatu du URL"
        Form2.Button4.Text = "Irekia"
        Form2.Button3.Text = "Irekia"
        ''Web Browsers''
        webbrowsers.Button1.Text = "Jaitsi"
        webbrowsers.Button2.Text = "Jaitsi"
        ''About that...''
        AboutThis.Text = "Buruz of..."
        ''AboutThis
        AboutThis.Button1.Text = "Aktiboak du modua du garatzailea"
        AboutThis.Button2.Text = "Txandaka du modua du garatzailea"
        AboutThis.Label1.Text = "Software hau ez da saiakera pirateria sustatu nahi"
        'Post
        post.Button1.Text = "Jaitsi"
        post.Button2.Text = "Jaitsi"
        post.Button3.Text = "Jaitsi"
        post.Button7.Text = "Jaitsi"
        post.Button8.Text = "Jaitsi"
        post.Button9.Text = "Jaitsi"
        post.Button11.Text = "Jaitsi"
        post.Button12.Text = "Jaitsi"
        post.Button14.Text = "Jaitsi"
        post.Button16.Text = "Jaitsi"
        post.Button17.Text = "Jaitsi"
        post.Button19.Text = "Jaitsi"
        post.Button23.Text = "Jaitsi"
        post.Button24.Text = "Jaitsi"
        post.Button25.Text = "Jaitsi"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Jaitsi"
        ubuntu.Button2.Text = "Jaitsi"
        ubuntu.Button3.Text = "Jaitsi"
        ubuntu.Button4.Text = "Jaitsi"
        ubuntu.Button5.Text = "Jaitsi"
        ubuntu.Button6.Text = "Jaitsi"
        ubuntu.Button7.Text = "Jaitsi"
        ubuntu.Button8.Text = "Jaitsi"
        ubuntu.Button9.Text = "Jaitsi"
        ubuntu.Button10.Text = "Jaitsi"
        ubuntu.Button11.Text = "Jaitsi"
        ubuntu.Button12.Text = "Jaitsi"
        'android
        androidx86.Button1.Text = "Jaitsi"
        androidx86.Button2.Text = "Jaitsi"
        androidx86.Button3.Text = "Jaitsi"
        androidx86.Button4.Text = "Jaitsi"
        androidx86.Button5.Text = "Jaitsi"
        androidx86.Button6.Text = "Jaitsi"
        androidx86.Button7.Text = "Jaitsi"
        androidx86.Button8.Text = "Jaitsi"
        androidx86.Button9.Text = "Jaitsi"
        androidx86.Button10.Text = "Jaitsi"
        androidx86.Button11.Text = "Jaitsi"
        androidx86.Button12.Text = "Jaitsi"
        androidx86.Button13.Text = "Jaitsi"
        androidx86.Button14.Text = "Jaitsi"
        androidx86.Button15.Text = "Jaitsi"
        'linux distros
        ld.Button1.Text = "Bertsiona"
        ld.Button2.Text = "Jaitsi"
        ld.Button3.Text = "Jaitsi"
        ld.Button12.Text = "Bertsiona"
    End Sub
    'Translations//
    Private Sub GaliciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GaliciaToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Store para o secretaria de Windows"
        'Descargar'
        Button1.Text = "Descargar"
        Button2.Text = "Descargar"
        Button3.Text = "Descargar"
        Button5.Text = "Descargar"
        Button7.Text = "Descargar"
        Button8.Text = "Descargar"
        Button9.Text = "Descargar"
        Button10.Text = "Descargar"
        Button13.Text = "Descargar"
        Button14.Text = "Descargar"
        Button11.Text = "Descargar"
        Button12.Text = "Descargar"
        Button16.Text = "Descargar"
        Button17.Text = "Descargar"
        Button18.Text = "Descargar"
        Button19.Text = "Descargar"
        Button20.Text = "Descargar"
        Button21.Text = "Descargar"
        Button22.Text = "Descargar"
        Button23.Text = "Descargar"
        Button24.Text = "Descargar"
        Button25.Text = "Descargar"
        'Categorias'
        Button4.Text = "Navegadores Web"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Configuración"
        ToolStripMenuItem2.Text = "Sobre de..."
        ToolStripMenuItem3.Text = "Saír"
        OpenDownloaderToolStripMenuItem.Text = "Descargador"
        TranslatorToolStripMenuItem.Text = "Tradutor"
        EnglishToolStripMenuItem.Text = "Inglés"
        SpanishToolStripMenuItem.Text = "Español"
        CatalanToolStripMenuItem.Text = "Catalán"
        GaliciaToolStripMenuItem.Text = "Gallego"
        PortugeseToolStripMenuItem.Text = "Portugués"
        CheckUpdatesToolStripMenuItem.Text = "Buscar actualizacións"
        ''Form 2''
        Form2.Text = "Download"
        Form2.Button1.Text = "Descargar"
        Form2.Label2.Text = "Directorio"
        Form2.MenuToolStripMenuItem.Text = "Configuración"
        Form2.EditURLToolStripMenuItem.Text = "Editar URL"
        Form2.UneditURLToolStripMenuItem.Text = "Deixar de editar la URL"
        Form2.Button4.Text = "Obrir"
        Form2.Button3.Text = "Obrir"

        ''Web Browsers''
        webbrowsers.Button1.Text = "Descargar"
        webbrowsers.Button2.Text = "Descargar"
        ''About that...''
        AboutThis.Text = "Sobre de..."
        ''AboutThis
        AboutThis.Button1.Text = "Activar o modo o desenvolvedor"
        AboutThis.Button2.Text = "Off o modo o desenvolvedor"
        AboutThis.Label1.Text = "Este software non intenta fomentar a pirateria"
        'Post
        post.Button1.Text = "Descargar"
        post.Button2.Text = "Descargar"
        post.Button3.Text = "Descargar"
        post.Button7.Text = "Descargar"
        post.Button8.Text = "Descargar"
        post.Button9.Text = "Descargar"
        post.Button11.Text = "Descargar"
        post.Button12.Text = "Descargar"
        post.Button14.Text = "Descargar"
        post.Button16.Text = "Descargar"
        post.Button17.Text = "Descargar"
        post.Button19.Text = "Descargar"
        post.Button23.Text = "Descargar"
        post.Button24.Text = "Descargar"
        post.Button25.Text = "Descargar"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Descargar"
        ubuntu.Button2.Text = "Descargar"
        ubuntu.Button3.Text = "Descargar"
        ubuntu.Button4.Text = "Descargar"
        ubuntu.Button5.Text = "Descargar"
        ubuntu.Button6.Text = "Descargar"
        ubuntu.Button7.Text = "Descargar"
        ubuntu.Button8.Text = "Descargar"
        ubuntu.Button9.Text = "Descargar"
        ubuntu.Button10.Text = "Descargar"
        ubuntu.Button11.Text = "Descargar"
        ubuntu.Button12.Text = "Descargar"
        'android
        androidx86.Button1.Text = "Descargar"
        androidx86.Button2.Text = "Descargar"
        androidx86.Button3.Text = "Descargar"
        androidx86.Button4.Text = "Descargar"
        androidx86.Button5.Text = "Descargar"
        androidx86.Button6.Text = "Descargar"
        androidx86.Button7.Text = "Descargar"
        androidx86.Button8.Text = "Descargar"
        androidx86.Button9.Text = "Descargar"
        androidx86.Button10.Text = "Descargar"
        androidx86.Button11.Text = "Descargar"
        androidx86.Button12.Text = "Descargar"
        androidx86.Button13.Text = "Descargar"
        androidx86.Button14.Text = "Descargar"
        androidx86.Button15.Text = "Descargar"
        'linux distros
        ld.Button1.Text = "Versión"
        ld.Button2.Text = "Descargar"
        ld.Button3.Text = "Descargar"
        ld.Button12.Text = "Versión"
    End Sub

    Private Sub PortugeseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortugeseToolStripMenuItem.Click
        ''Form 1''
        Me.Text = "Windows Loja para o desktop de Windows"
        'Baixar'
        Button1.Text = "Baixar"
        Button2.Text = "Baixar"
        Button3.Text = "Baixar"
        Button5.Text = "Baixar"
        Button7.Text = "Baixar"
        Button8.Text = "Baixar"
        Button9.Text = "Baixar"
        Button10.Text = "Baixar"
        Button13.Text = "Baixar"
        Button14.Text = "Baixar"
        Button11.Text = "Baixar"
        Button12.Text = "Baixar"
        Button16.Text = "Baixar"
        Button17.Text = "Baixar"
        Button18.Text = "Baixar"
        Button19.Text = "Baixar"
        Button20.Text = "Baixar"
        Button21.Text = "Baixar"
        Button22.Text = "Baixar"
        Button23.Text = "Baixar"
        Button24.Text = "Baixar"
        Button25.Text = "Baixar"
        'Categorias'
        Button4.Text = "Navegadores da Web"
        'ToolStripMenu'
        ToolStripMenuItem1.Text = "Configurações"
        ToolStripMenuItem2.Text = "Sobre o que..."
        ToolStripMenuItem3.Text = "Sair"
        OpenDownloaderToolStripMenuItem.Text = "Downloader"
        TranslatorToolStripMenuItem.Text = "Tradução"
        EnglishToolStripMenuItem.Text = "Inglês"
        SpanishToolStripMenuItem.Text = "Espanhol"
        CatalanToolStripMenuItem.Text = "Catalão"
        GaliciaToolStripMenuItem.Text = "Gallego"
        CheckUpdatesToolStripMenuItem.Text = "Procurar atualizações"
        ''Form 2''
        Form2.Text = "Downloader"
        Form2.Button1.Text = "Baixar"
        Form2.Label2.Text = "Diretório"
        Form2.MenuToolStripMenuItem.Text = "Configurações"
        Form2.EditURLToolStripMenuItem.Text = "Editar URL"
        Form2.UneditURLToolStripMenuItem.Text = "Deixar de editar o URL"
        Form2.Button4.Text = "Abrir"
        Form2.Button3.Text = "Abrir"
        ''Web Browsers''
        webbrowsers.Button1.Text = "Baixar"
        webbrowsers.Button2.Text = "Baixar"
        ''About that...''
        AboutThis.Text = "Sobre o que..."
        ''AboutThis
        AboutThis.Button1.Text = "Ative modo de desenvolvedor"
        AboutThis.Button2.Text = "Off modo de desenvolvedor"
        AboutThis.Label1.Text = "Este software não tenta incetivar a pirateria"
        'Post
        post.Button1.Text = "Baixar"
        post.Button2.Text = "Baixar"
        post.Button3.Text = "Baixar"
        post.Button7.Text = "Baixar"
        post.Button8.Text = "Baixar"
        post.Button9.Text = "Baixar"
        post.Button11.Text = "Baixar"
        post.Button12.Text = "Baixar"
        post.Button14.Text = "Baixar"
        post.Button16.Text = "Baixar"
        post.Button17.Text = "Baixar"
        post.Button19.Text = "Baixar"
        post.Button23.Text = "Baixar"
        post.Button24.Text = "Baixar"
        post.Button25.Text = "Baixar"
        'linux
        'ubuntu
        ubuntu.Button1.Text = "Baixar"
        ubuntu.Button2.Text = "Baixar"
        ubuntu.Button3.Text = "Baixar"
        ubuntu.Button4.Text = "Baixar"
        ubuntu.Button5.Text = "Baixar"
        ubuntu.Button6.Text = "Baixar"
        ubuntu.Button7.Text = "Baixar"
        ubuntu.Button8.Text = "Baixar"
        ubuntu.Button9.Text = "Baixar"
        ubuntu.Button10.Text = "Baixar"
        ubuntu.Button11.Text = "Baixar"
        ubuntu.Button12.Text = "Baixar"
        'android
        androidx86.Button1.Text = "Baixar"
        androidx86.Button2.Text = "Baixar"
        androidx86.Button3.Text = "Baixar"
        androidx86.Button4.Text = "Baixar"
        androidx86.Button5.Text = "Baixar"
        androidx86.Button6.Text = "Baixar"
        androidx86.Button7.Text = "Baixar"
        androidx86.Button8.Text = "Baixar"
        androidx86.Button9.Text = "Baixar"
        androidx86.Button10.Text = "Baixar"
        androidx86.Button11.Text = "Baixar"
        androidx86.Button12.Text = "Baixar"
        androidx86.Button13.Text = "Baixar"
        androidx86.Button14.Text = "Baixar"
        androidx86.Button15.Text = "Baixar"
        'linux distros
        ld.Button1.Text = "Versão"
        ld.Button2.Text = "Baixar"
        ld.Button3.Text = "Baixar"
        ld.Button12.Text = "Versão"
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        AboutThis.Show()
    End Sub



    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        webbrowsers.ShowDialog()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        webbrowsers.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        webbrowsers.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As New System.Uri("https://sourceforge.net/projects/windowsstoreforwindowsdesktop/files/ALPHA/0013.exe/download")
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            MsgBox("Updates avaliable:" + "  0.0.1.3")
        Catch ex As Exception
            req = Nothing
            MsgBox("No updates available or check your internet conexion")
        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        webbrowsers.ShowDialog()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        post.ShowDialog()
    End Sub
    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        post.ShowDialog()
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        post.ShowDialog()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        post.ShowDialog()
    End Sub
    Private Sub OpenDownloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDownloaderToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        post.ShowDialog()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form2.TextBox1.Text = "http://silverlight.dlservice.microsoft.com/download/F/8/C/F8C0EACB-92D0-4722-9B18-965DD2A681E9/30514.00/Silverlight.exe"
        Form2.TextBox2.Text = "C:\Downloads\Silverlight.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.TextBox1.Text = "http://download.piriform.com/ccsetup418.exe"
        Form2.TextBox2.Text = "C:\Downloads\ccsetup418.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form2.TextBox1.Text = "http://download.piriform.com/spsetup126.exe"
        Form2.TextBox2.Text = "C:\Downloads\spsetup126.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form2.TextBox1.Text = "http://aihdownload.adobe.com/bin/live/install_reader11_es_mssd_aaa_aih.exe"
        Form2.TextBox2.Text = "C:\Downloads\install_reader11_es_mssd_aaa_aih.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form2.TextBox1.Text = "http://downloadeu1.teamviewer.com/download/TeamViewer_Setup_es.exe"
        Form2.TextBox2.Text = "C:\Downloads\TeamViewer_Setup_es.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Form2.TextBox1.Text = "https://eaassets-a.akamaihd.net/Origin-Client-Download/origin/live/OriginThinSetup.exe"
        Form2.TextBox2.Text = "C:\Downloads\OriginThinSetup.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form2.TextBox1.Text = "http://sourceforge.net/projects/filezilla/files/FileZilla_Client/3.9.0.5/FileZilla_3.9.0.5_win32-setup.exe/download?accel_key=57%3A1412952756%3Ahttps%253A//filezilla-project.org/download.php%253Ftype%253Dclient%3Aede19675%246aa7d8d4f40a3d7bbb27961414332ebf4d026ee3&click_id=131ea4de-508d-11e4-8a88-0200ac1d1d8b&source=accel"
        Form2.TextBox2.Text = "C:\Downloads\FileZilla_3.9.0.5_win32-setup.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Form2.TextBox1.Text = "https://dl-web.dropbox.com/installer?build_no=2.10.27&tag=eJyrVipOLS7OzM-Lz0xRslIwNLM0MjW3sDAyMLQ0MDO1MDA2NDM3MzK2MDYzNDU3tzQ1Njc1MbCoBQCqiA3O&build_key=Dropbox&authenticode_sign=True&plat=win"
        Form2.TextBox2.Text = "C:\Downloads\DropboxInstaller.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Form2.TextBox1.Text = "http://cdn.bluestacks.com/public/beta-1/BlueStacks-SplitInstaller_native.exe"
        Form2.TextBox2.Text = "C:\Downloads\BlueStacks-SplitInstaller_native.exe"
        Form2.ShowDialog()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Form2.TextBox1.Text = "http://mirror14.soft24.com/getfile.php?p=http://eu-uk1.disc-tools.com/9b3ae12499d4e5907037b1cdadabb38a/DTLite4491-0356.exe"
        Form2.TextBox2.Text = "C:\Downloads\DTLite4491-0356.exe"
        Form2.ShowDialog()
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        WindowsVer.ShowDialog()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ld.ShowDialog()
    End Sub
End Class
