using UnityEditor;

namespace MenuItemSettings
{
    // create MenuItem that generates Script files from Template files.
    public partial class CreateScriptFromTemplates
    {
        // Path Settings
        private const string PATH_TEMPLATEFOLDER = "Assets/Client/Scripts/Library/MenuItemSettings/Templates";
        private const string NAME_NEWFILE = "New File.cs";

        // MenuItem Parameters Settings
        private const string ROOT_MENUITEM = "Assets/Create/Create Script From Templates/";
        private const int PRIORITY = 30;

        private const string EDITOR = "Editor Script";
        private const string CREATE_SCRIPT_FROM_TEMPLATES = "CreateScriptFromTemplates";

        // MenuItems
        [MenuItem(ROOT_MENUITEM + EDITOR, priority = PRIORITY)]
        public static void CreateEditorScript() => CreateScriptFile("EditorTemplate.txt", NAME_NEWFILE);
        [MenuItem(ROOT_MENUITEM + CREATE_SCRIPT_FROM_TEMPLATES, priority = PRIORITY)]
        public static void CreateMenuItemSettings() => CreateScriptFile("CreateScriptFromTemplatesTemplate.txt", "CreateScriptFromTemplates.cs");

        private static void CreateScriptFile(string templateFilePath, string fileName)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(System.IO.Path.Combine(PATH_TEMPLATEFOLDER, templateFilePath), fileName);
        }
    }
}
