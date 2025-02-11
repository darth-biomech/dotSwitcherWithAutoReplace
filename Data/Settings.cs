/**
 *   DotSwitcher: a simple keyboard layout switcher
 *   Copyright (C) 2014-2019 Kirill Mokhovtsev / kurumpa
 *   Contact: kiev.programmer@gmail.com
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace dotSwitcher.Data
{
    [Serializable]
    public sealed class Settings : ApplicationSettingsBase, ISettings
    {
        public static Settings Init()
        {
            var settings = new Settings();
            settings.Reload();
            if (settings.SwitchHotkey.KeyData == Keys.None)
            {
                settings.SwitchHotkey = new KeyboardEventArgs(Keys.Pause, false);
            }
            if (settings.ConvertSelectionHotkey.KeyData == Keys.None)
            {
                settings.ConvertSelectionHotkey = new KeyboardEventArgs(Keys.F12 | Keys.ControlKey, false);
            }
            if (settings.ReplaceHotkey.KeyData == Keys.None)
            {
                settings.ReplaceHotkey = new KeyboardEventArgs(Keys.F12 | Keys.Shift, false);
            }
            if (settings.ShowTrayIcon == null)
            {
                settings.ShowTrayIcon = true;
            }
            if (settings.AutoReplace == null)
            {
                settings.AutoReplace = false;
            }
            if (settings.AutoReplaceSpace == null)
            {
                settings.AutoReplaceSpace = true;
            }
            if (settings.AutoReplaceEnter == null)
            {
                settings.AutoReplaceEnter = true;
            }
            if (settings.SwitchDelay < 1)
            {
                settings.SwitchDelay = 20;
            }
            if (settings.ReplacementList == null)
            {
                settings.ReplacementList = Array.Empty<string>();
            }
            settings.Save();
            return settings;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public string[] ReplacementList 
        {
            get => (string[])this["ReplacementList"];
            set => this["ReplacementList"] = (string[])value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public KeyboardEventArgs ReplaceHotkey
        {
            get => (KeyboardEventArgs)this["ReplaceHotkey"];
            set => this["ReplaceHotkey"] = (KeyboardEventArgs)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public KeyboardEventArgs SwitchHotkey
        {
            get => (KeyboardEventArgs)this["SwitchHotkey"];
            set => this["SwitchHotkey"] = (KeyboardEventArgs)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public KeyboardEventArgs ConvertSelectionHotkey
        {
            get => (KeyboardEventArgs)this["ConvertSelectionHotkey"];
            set => this["ConvertSelectionHotkey"] = (KeyboardEventArgs)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public KeyboardEventArgs SwitchLayoutHotkey
        {
            get => (KeyboardEventArgs)this["SwitchLayoutHotkey"];
            set => this["SwitchLayoutHotkey"] = (KeyboardEventArgs)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? AutoStart
        {
            get => (bool?)this["AutoStart"];
            set => this["AutoStart"] = (bool?)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? AutoReplace
        {
            get => (bool?)this["AutoReplace"];
            set => this["AutoReplace"] = (bool?)value;
        }
        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? AutoReplaceSpace
        {
            get => (bool?)this["AutoReplaceSpace"];
            set => this["AutoReplaceSpace"] = (bool?)value;
        }
        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? AutoReplaceEnter
        {
            get => (bool?)this["AutoReplaceEnter"];
            set => this["AutoReplaceEnter"] = (bool?)value;
        }
        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? ShowTrayIcon
        {
            get => (bool?)this["ShowTrayIcon"];
            set => this["ShowTrayIcon"] = (bool?)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public int SwitchDelay
        {
            get => (int)this["SwitchDelay"];
            set => this["SwitchDelay"] = (int)value;
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public bool? SmartSelection
        {
            get => (bool?)this["SmartSelection"];
            set => this["SmartSelection"] = (bool?)value;
        }

        public void SaveReplacementList(List<ReplacementEntry> replacementList)
        {
            if (replacementList.Count <= 0) return;
            
            string[] result = new string[replacementList.Count];
            
            for (int i = 0; i < replacementList.Count; i++)
            {
                result[i] = replacementList[i].Serialize();
            }
            
            ReplacementList = result;
        }
    }
    
}
