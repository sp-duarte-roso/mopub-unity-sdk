// Asset data and providers generated from asset content
#region Using Statements
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{

    #region Fonts

    /// <summary>
    /// Manages a UnityEngine.Font object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class FontAsset : AssetObject<UnityEngine.Font>
    {
        public static implicit operator FontAsset(UnityEngine.Font unityObject)
        {
            return new FontAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator FontAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Fonts[assetId];
        }
    }

    /// <summary>
    /// FontAsset data provider. Contains references to all fonts in the project.
    /// </summary>
    public partial class FontAssetData : BindableCollection<FontAsset>
    {
        #region Fields

        public readonly FontAsset Ebrima;
        public readonly FontAsset InconsolataRegular;
        public readonly FontAsset SegoeUI;

        #endregion

        #region Constructor

        public FontAssetData()
        {
            Ebrima = new FontAsset { Id = "Ebrima", IsResource = true, RelativePath = "Fonts/" };
            InconsolataRegular = new FontAsset { Id = "Inconsolata-Regular", IsResource = true, RelativePath = "Fonts/" };
            SegoeUI = new FontAsset { Id = "Segoe UI", IsResource = true, RelativePath = "Fonts/" };

            Add(Ebrima);
            Add(InconsolataRegular);
            Add(SegoeUI);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static FontAssetData Fonts = new FontAssetData();
    }

    #endregion

    #region Materials

    /// <summary>
    /// Manages a UnityEngine.Material object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class MaterialAsset : AssetObject<UnityEngine.Material>
    {
        public static implicit operator MaterialAsset(UnityEngine.Material unityObject)
        {
            return new MaterialAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator MaterialAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Materials[assetId];
        }
    }

    /// <summary>
    /// MaterialAsset data provider. Contains references to all materials in the project.
    /// </summary>
    public partial class MaterialAssetData : BindableCollection<MaterialAsset>
    {
        #region Fields

        public readonly MaterialAsset UIFastDefault;

        #endregion

        #region Constructor

        public MaterialAssetData()
        {
            UIFastDefault = new MaterialAsset { Id = "UI-Fast-Default", IsResource = true, RelativePath = "Materials/" };

            Add(UIFastDefault);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static MaterialAssetData Materials = new MaterialAssetData();
    }

    #endregion

    #region Sprites

    /// <summary>
    /// Manages a UnityEngine.Sprite object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class SpriteAsset : AssetObject<UnityEngine.Sprite>
    {
        public static implicit operator SpriteAsset(UnityEngine.Sprite unityObject)
        {
            return new SpriteAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator SpriteAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Sprites[assetId];
        }
    }

    /// <summary>
    /// SpriteAsset data provider. Contains references to all sprites in the project.
    /// </summary>
    public partial class SpriteAssetData : BindableCollection<SpriteAsset>
    {
        #region Fields

        public readonly SpriteAsset Checkmark;
        public readonly SpriteAsset Chevrondown;
        public readonly SpriteAsset Chevronleft;
        public readonly SpriteAsset Chevronright;
        public readonly SpriteAsset CheckBox;
        public readonly SpriteAsset CheckBoxPressed;
        public readonly SpriteAsset CloseButton;
        public readonly SpriteAsset ComboBoxButton;
        public readonly SpriteAsset ComboBoxButtonPressed;
        public readonly SpriteAsset ContextMenuBg;
        public readonly SpriteAsset DesignerGrid;
        public readonly SpriteAsset DesignerGrid2;
        public readonly SpriteAsset EditorGrid;
        public readonly SpriteAsset ExpanderArrowDown;
        public readonly SpriteAsset ExpanderArrowRight;
        public readonly SpriteAsset HamburgerMenuIcon;
        public readonly SpriteAsset HamburgerMenuIconPressed;
        public readonly SpriteAsset ListSelection;
        public readonly SpriteAsset Lock;
        public readonly SpriteAsset RadioButton;
        public readonly SpriteAsset RadioButtonPressed;
        public readonly SpriteAsset RainbowSquare;
        public readonly SpriteAsset RoundedSquare10_5px;
        public readonly SpriteAsset RoundedSquareFull128px;
        public readonly SpriteAsset RoundedSquareFull256px;
        public readonly SpriteAsset RoundedSquareFull512px;
        public readonly SpriteAsset Selection;
        public readonly SpriteAsset TooltipArrow;
        public readonly SpriteAsset Delighticon;
        public readonly SpriteAsset Eye16;
        public readonly SpriteAsset Eye64;
        public readonly SpriteAsset Fullscreen;

        #endregion

        #region Constructor

        public SpriteAssetData()
        {
            Checkmark = new SpriteAsset { Id = "checkmark", IsResource = true, RelativePath = "Sprites/" };
            Chevrondown = new SpriteAsset { Id = "chevron-down", IsResource = true, RelativePath = "Sprites/" };
            Chevronleft = new SpriteAsset { Id = "chevron-left", IsResource = true, RelativePath = "Sprites/" };
            Chevronright = new SpriteAsset { Id = "chevron-right", IsResource = true, RelativePath = "Sprites/" };
            CheckBox = new SpriteAsset { Id = "CheckBox", IsResource = true, RelativePath = "Sprites/" };
            CheckBoxPressed = new SpriteAsset { Id = "CheckBoxPressed", IsResource = true, RelativePath = "Sprites/" };
            CloseButton = new SpriteAsset { Id = "CloseButton", IsResource = true, RelativePath = "Sprites/" };
            ComboBoxButton = new SpriteAsset { Id = "ComboBoxButton", IsResource = true, RelativePath = "Sprites/" };
            ComboBoxButtonPressed = new SpriteAsset { Id = "ComboBoxButtonPressed", IsResource = true, RelativePath = "Sprites/" };
            ContextMenuBg = new SpriteAsset { Id = "ContextMenuBg", IsResource = true, RelativePath = "Sprites/" };
            DesignerGrid = new SpriteAsset { Id = "DesignerGrid", IsResource = true, RelativePath = "Sprites/" };
            DesignerGrid2 = new SpriteAsset { Id = "DesignerGrid2", IsResource = true, RelativePath = "Sprites/" };
            EditorGrid = new SpriteAsset { Id = "EditorGrid", IsResource = true, RelativePath = "Sprites/" };
            ExpanderArrowDown = new SpriteAsset { Id = "ExpanderArrowDown", IsResource = true, RelativePath = "Sprites/" };
            ExpanderArrowRight = new SpriteAsset { Id = "ExpanderArrowRight", IsResource = true, RelativePath = "Sprites/" };
            HamburgerMenuIcon = new SpriteAsset { Id = "HamburgerMenuIcon", IsResource = true, RelativePath = "Sprites/" };
            HamburgerMenuIconPressed = new SpriteAsset { Id = "HamburgerMenuIconPressed", IsResource = true, RelativePath = "Sprites/" };
            ListSelection = new SpriteAsset { Id = "ListSelection", IsResource = true, RelativePath = "Sprites/" };
            Lock = new SpriteAsset { Id = "Lock", IsResource = true, RelativePath = "Sprites/" };
            RadioButton = new SpriteAsset { Id = "RadioButton", IsResource = true, RelativePath = "Sprites/" };
            RadioButtonPressed = new SpriteAsset { Id = "RadioButtonPressed", IsResource = true, RelativePath = "Sprites/" };
            RainbowSquare = new SpriteAsset { Id = "RainbowSquare", IsResource = true, RelativePath = "Sprites/" };
            RoundedSquare10_5px = new SpriteAsset { Id = "RoundedSquare10_5px", IsResource = true, RelativePath = "Sprites/" };
            RoundedSquareFull128px = new SpriteAsset { Id = "RoundedSquareFull@128px", IsResource = true, RelativePath = "Sprites/" };
            RoundedSquareFull256px = new SpriteAsset { Id = "RoundedSquareFull@256px", IsResource = true, RelativePath = "Sprites/" };
            RoundedSquareFull512px = new SpriteAsset { Id = "RoundedSquareFull@512px", IsResource = true, RelativePath = "Sprites/" };
            Selection = new SpriteAsset { Id = "Selection", IsResource = true, RelativePath = "Sprites/" };
            TooltipArrow = new SpriteAsset { Id = "TooltipArrow", IsResource = true, RelativePath = "Sprites/" };
            Delighticon = new SpriteAsset { Id = "delight-icon", IsResource = true, RelativePath = "Sprites/" };
            Eye16 = new SpriteAsset { Id = "eye16", IsResource = true, RelativePath = "Sprites/" };
            Eye64 = new SpriteAsset { Id = "eye64", IsResource = true, RelativePath = "Sprites/" };
            Fullscreen = new SpriteAsset { Id = "fullscreen", IsResource = true, RelativePath = "Sprites/" };

            Add(Checkmark);
            Add(Chevrondown);
            Add(Chevronleft);
            Add(Chevronright);
            Add(CheckBox);
            Add(CheckBoxPressed);
            Add(CloseButton);
            Add(ComboBoxButton);
            Add(ComboBoxButtonPressed);
            Add(ContextMenuBg);
            Add(DesignerGrid);
            Add(DesignerGrid2);
            Add(EditorGrid);
            Add(ExpanderArrowDown);
            Add(ExpanderArrowRight);
            Add(HamburgerMenuIcon);
            Add(HamburgerMenuIconPressed);
            Add(ListSelection);
            Add(Lock);
            Add(RadioButton);
            Add(RadioButtonPressed);
            Add(RainbowSquare);
            Add(RoundedSquare10_5px);
            Add(RoundedSquareFull128px);
            Add(RoundedSquareFull256px);
            Add(RoundedSquareFull512px);
            Add(Selection);
            Add(TooltipArrow);
            Add(Delighticon);
            Add(Eye16);
            Add(Eye64);
            Add(Fullscreen);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static SpriteAssetData Sprites = new SpriteAssetData();
    }

    #endregion

    #region TMP_FontAssets

    /// <summary>
    /// Manages a TMPro.TMP_FontAsset object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_FontAsset : AssetObject<TMPro.TMP_FontAsset>
    {
        public static implicit operator TMP_FontAsset(TMPro.TMP_FontAsset unityObject)
        {
            return new TMP_FontAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_FontAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_FontAssets[assetId];
        }
    }

    /// <summary>
    /// TMP_FontAsset data provider. Contains references to all tmp_fontassets in the project.
    /// </summary>
    public partial class TMP_FontAssetData : BindableCollection<TMP_FontAsset>
    {
        #region Fields

        public readonly TMP_FontAsset EbrimaSDF;
        public readonly TMP_FontAsset InconsolataRegularSDF;
        public readonly TMP_FontAsset SegoeUISDF;

        #endregion

        #region Constructor

        public TMP_FontAssetData()
        {
            EbrimaSDF = new TMP_FontAsset { Id = "Ebrima SDF", IsResource = true, RelativePath = "Fonts/" };
            InconsolataRegularSDF = new TMP_FontAsset { Id = "Inconsolata-Regular SDF", IsResource = true, RelativePath = "Fonts/" };
            SegoeUISDF = new TMP_FontAsset { Id = "Segoe UI SDF", IsResource = true, RelativePath = "Fonts/" };

            Add(EbrimaSDF);
            Add(InconsolataRegularSDF);
            Add(SegoeUISDF);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static TMP_FontAssetData TMP_FontAssets = new TMP_FontAssetData();
    }

    #endregion

    #region Shaders

    /// <summary>
    /// Manages a UnityEngine.Shader object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class ShaderAsset : AssetObject<UnityEngine.Shader>
    {
        public static implicit operator ShaderAsset(UnityEngine.Shader unityObject)
        {
            return new ShaderAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator ShaderAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Shaders[assetId];
        }
    }

    /// <summary>
    /// ShaderAsset data provider. Contains references to all shaders in the project.
    /// </summary>
    public partial class ShaderAssetData : BindableCollection<ShaderAsset>
    {
        #region Fields

        public readonly ShaderAsset UIFastDefault;

        #endregion

        #region Constructor

        public ShaderAssetData()
        {
            UIFastDefault = new ShaderAsset { Id = "UI-Fast-Default", IsResource = true, RelativePath = "Shaders/" };

            Add(UIFastDefault);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static ShaderAssetData Shaders = new ShaderAssetData();
    }

    #endregion

    #region TMP_ColorGradients

    /// <summary>
    /// Manages a TMPro.TMP_ColorGradient object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_ColorGradientAsset : AssetObject<TMPro.TMP_ColorGradient>
    {
        public static implicit operator TMP_ColorGradientAsset(TMPro.TMP_ColorGradient unityObject)
        {
            return new TMP_ColorGradientAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_ColorGradientAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_ColorGradients[assetId];
        }
    }

    /// <summary>
    /// TMP_ColorGradientAsset data provider. Contains references to all tmp_colorgradients in the project.
    /// </summary>
    public partial class TMP_ColorGradientAssetData : BindableCollection<TMP_ColorGradientAsset>
    {
    }

    public static partial class Assets
    {
        public static TMP_ColorGradientAssetData TMP_ColorGradients = new TMP_ColorGradientAssetData();
    }

    #endregion

    #region TMP_SpriteAssets

    /// <summary>
    /// Manages a TMPro.TMP_SpriteAsset object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_SpriteAsset : AssetObject<TMPro.TMP_SpriteAsset>
    {
        public static implicit operator TMP_SpriteAsset(TMPro.TMP_SpriteAsset unityObject)
        {
            return new TMP_SpriteAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_SpriteAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_SpriteAssets[assetId];
        }
    }

    /// <summary>
    /// TMP_SpriteAsset data provider. Contains references to all tmp_spriteassets in the project.
    /// </summary>
    public partial class TMP_SpriteAssetData : BindableCollection<TMP_SpriteAsset>
    {
    }

    public static partial class Assets
    {
        public static TMP_SpriteAssetData TMP_SpriteAssets = new TMP_SpriteAssetData();
    }

    #endregion

    #region TMP_StyleSheets

    /// <summary>
    /// Manages a TMPro.TMP_StyleSheet object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_StyleSheetAsset : AssetObject<TMPro.TMP_StyleSheet>
    {
        public static implicit operator TMP_StyleSheetAsset(TMPro.TMP_StyleSheet unityObject)
        {
            return new TMP_StyleSheetAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_StyleSheetAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_StyleSheets[assetId];
        }
    }

    /// <summary>
    /// TMP_StyleSheetAsset data provider. Contains references to all tmp_stylesheets in the project.
    /// </summary>
    public partial class TMP_StyleSheetAssetData : BindableCollection<TMP_StyleSheetAsset>
    {
    }

    public static partial class Assets
    {
        public static TMP_StyleSheetAssetData TMP_StyleSheets = new TMP_StyleSheetAssetData();
    }

    #endregion

    #region TMP_InputValidators

    /// <summary>
    /// Manages a TMPro.TMP_InputValidator object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_InputValidatorAsset : AssetObject<TMPro.TMP_InputValidator>
    {
        public static implicit operator TMP_InputValidatorAsset(TMPro.TMP_InputValidator unityObject)
        {
            return new TMP_InputValidatorAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_InputValidatorAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_InputValidators[assetId];
        }
    }

    /// <summary>
    /// TMP_InputValidatorAsset data provider. Contains references to all tmp_inputvalidators in the project.
    /// </summary>
    public partial class TMP_InputValidatorAssetData : BindableCollection<TMP_InputValidatorAsset>
    {
    }

    public static partial class Assets
    {
        public static TMP_InputValidatorAssetData TMP_InputValidators = new TMP_InputValidatorAssetData();
    }

    #endregion

    #region Textures

    /// <summary>
    /// Manages a UnityEngine.Texture object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TextureAsset : AssetObject<UnityEngine.Texture>
    {
        public static implicit operator TextureAsset(UnityEngine.Texture unityObject)
        {
            return new TextureAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TextureAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Textures[assetId];
        }
    }

    /// <summary>
    /// TextureAsset data provider. Contains references to all textures in the project.
    /// </summary>
    public partial class TextureAssetData : BindableCollection<TextureAsset>
    {
    }

    public static partial class Assets
    {
        public static TextureAssetData Textures = new TextureAssetData();
    }

    #endregion
}
