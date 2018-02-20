<?php
/*
 * --------------------------------------------------------------------------------------------------------------------
 * <copyright company="Aspose" file="HtmlSaveOptionsData.php">
 *   Copyright (c) 2017 Aspose.Words for Cloud
 * </copyright>
 * <summary>
 *   Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 * 
 *  The above copyright notice and this permission notice shall be included in all
 *  copies or substantial portions of the Software.
 * 
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.
 * </summary>
 * --------------------------------------------------------------------------------------------------------------------
 */
/*
 * HtmlSaveOptionsData
 */

namespace Aspose\Words\Model;
use \Aspose\Words\ObjectSerializer;

/*
 * HtmlSaveOptionsData
 *
 * @description container class for html save options
 */
class HtmlSaveOptionsData extends SaveOptionsData 
{
    const DISCRIMINATOR = null;

    /*
     * The original name of the model.
     *
     * @var string
     */
    protected static $swaggerModelName = "HtmlSaveOptionsData";

    /*
     * Array of property to type mappings. Used for (de)serialization
     *
     * @var string[]
     */
    protected static $swaggerTypes = [
        'pretty_format' => 'bool',
        'allow_negative_indent' => 'bool',
        'css_style_sheet_file_name' => 'string',
        'css_style_sheet_type' => 'string',
        'document_split_criteria' => 'string',
        'document_split_heading_level' => 'int',
        'encoding' => 'string',
        'export_document_properties' => 'bool',
        'export_fonts_as_base64' => 'bool',
        'export_font_resources' => 'bool',
        'export_headers_footers_mode' => 'string',
        'export_images_as_base64' => 'bool',
        'export_language_information' => 'bool',
        'export_list_labels' => 'string',
        'export_metafile_as_raster' => 'bool',
        'export_original_url_for_linked_images' => 'bool',
        'export_page_margins' => 'bool',
        'export_page_setup' => 'bool',
        'export_relative_font_size' => 'bool',
        'export_roundtrip_information' => 'bool',
        'export_text_box_as_svg' => 'bool',
        'export_text_input_form_field_as_text' => 'bool',
        'export_toc_page_numbers' => 'bool',
        'export_xhtml_transitional' => 'bool',
        'fonts_folder' => 'string',
        'fonts_folder_alias' => 'string',
        'font_resources_subsetting_size_threshold' => 'int',
        'html_version' => 'string',
        'images_folder' => 'string',
        'images_folder_alias' => 'string',
        'image_resolution' => 'int',
        'office_math_output_mode' => 'string',
        'resource_folder' => 'string',
        'resource_folder_alias' => 'string',
        'scale_image_to_shape_size' => 'bool',
        'table_width_output_mode' => 'string',
        'export_drop_down_form_field_as_text' => 'bool'
    ];

    /*
     * Array of property to format mappings. Used for (de)serialization
     *
     * @var string[]
     */
    protected static $swaggerFormats = [
        'pretty_format' => null,
        'allow_negative_indent' => null,
        'css_style_sheet_file_name' => null,
        'css_style_sheet_type' => null,
        'document_split_criteria' => null,
        'document_split_heading_level' => 'int32',
        'encoding' => null,
        'export_document_properties' => null,
        'export_fonts_as_base64' => null,
        'export_font_resources' => null,
        'export_headers_footers_mode' => null,
        'export_images_as_base64' => null,
        'export_language_information' => null,
        'export_list_labels' => null,
        'export_metafile_as_raster' => null,
        'export_original_url_for_linked_images' => null,
        'export_page_margins' => null,
        'export_page_setup' => null,
        'export_relative_font_size' => null,
        'export_roundtrip_information' => null,
        'export_text_box_as_svg' => null,
        'export_text_input_form_field_as_text' => null,
        'export_toc_page_numbers' => null,
        'export_xhtml_transitional' => null,
        'fonts_folder' => null,
        'fonts_folder_alias' => null,
        'font_resources_subsetting_size_threshold' => 'int32',
        'html_version' => null,
        'images_folder' => null,
        'images_folder_alias' => null,
        'image_resolution' => 'int32',
        'office_math_output_mode' => null,
        'resource_folder' => null,
        'resource_folder_alias' => null,
        'scale_image_to_shape_size' => null,
        'table_width_output_mode' => null,
        'export_drop_down_form_field_as_text' => null
    ];

    /*
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes + parent::swaggerTypes();
    }

    /*
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats + parent::swaggerFormats();
    }

    /*
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'pretty_format' => 'PrettyFormat',
        'allow_negative_indent' => 'AllowNegativeIndent',
        'css_style_sheet_file_name' => 'CssStyleSheetFileName',
        'css_style_sheet_type' => 'CssStyleSheetType',
        'document_split_criteria' => 'DocumentSplitCriteria',
        'document_split_heading_level' => 'DocumentSplitHeadingLevel',
        'encoding' => 'Encoding',
        'export_document_properties' => 'ExportDocumentProperties',
        'export_fonts_as_base64' => 'ExportFontsAsBase64',
        'export_font_resources' => 'ExportFontResources',
        'export_headers_footers_mode' => 'ExportHeadersFootersMode',
        'export_images_as_base64' => 'ExportImagesAsBase64',
        'export_language_information' => 'ExportLanguageInformation',
        'export_list_labels' => 'ExportListLabels',
        'export_metafile_as_raster' => 'ExportMetafileAsRaster',
        'export_original_url_for_linked_images' => 'ExportOriginalUrlForLinkedImages',
        'export_page_margins' => 'ExportPageMargins',
        'export_page_setup' => 'ExportPageSetup',
        'export_relative_font_size' => 'ExportRelativeFontSize',
        'export_roundtrip_information' => 'ExportRoundtripInformation',
        'export_text_box_as_svg' => 'ExportTextBoxAsSvg',
        'export_text_input_form_field_as_text' => 'ExportTextInputFormFieldAsText',
        'export_toc_page_numbers' => 'ExportTocPageNumbers',
        'export_xhtml_transitional' => 'ExportXhtmlTransitional',
        'fonts_folder' => 'FontsFolder',
        'fonts_folder_alias' => 'FontsFolderAlias',
        'font_resources_subsetting_size_threshold' => 'FontResourcesSubsettingSizeThreshold',
        'html_version' => 'HtmlVersion',
        'images_folder' => 'ImagesFolder',
        'images_folder_alias' => 'ImagesFolderAlias',
        'image_resolution' => 'ImageResolution',
        'office_math_output_mode' => 'OfficeMathOutputMode',
        'resource_folder' => 'ResourceFolder',
        'resource_folder_alias' => 'ResourceFolderAlias',
        'scale_image_to_shape_size' => 'ScaleImageToShapeSize',
        'table_width_output_mode' => 'TableWidthOutputMode',
        'export_drop_down_form_field_as_text' => 'ExportDropDownFormFieldAsText'
    ];

    /*
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'pretty_format' => 'setPrettyFormat',
        'allow_negative_indent' => 'setAllowNegativeIndent',
        'css_style_sheet_file_name' => 'setCssStyleSheetFileName',
        'css_style_sheet_type' => 'setCssStyleSheetType',
        'document_split_criteria' => 'setDocumentSplitCriteria',
        'document_split_heading_level' => 'setDocumentSplitHeadingLevel',
        'encoding' => 'setEncoding',
        'export_document_properties' => 'setExportDocumentProperties',
        'export_fonts_as_base64' => 'setExportFontsAsBase64',
        'export_font_resources' => 'setExportFontResources',
        'export_headers_footers_mode' => 'setExportHeadersFootersMode',
        'export_images_as_base64' => 'setExportImagesAsBase64',
        'export_language_information' => 'setExportLanguageInformation',
        'export_list_labels' => 'setExportListLabels',
        'export_metafile_as_raster' => 'setExportMetafileAsRaster',
        'export_original_url_for_linked_images' => 'setExportOriginalUrlForLinkedImages',
        'export_page_margins' => 'setExportPageMargins',
        'export_page_setup' => 'setExportPageSetup',
        'export_relative_font_size' => 'setExportRelativeFontSize',
        'export_roundtrip_information' => 'setExportRoundtripInformation',
        'export_text_box_as_svg' => 'setExportTextBoxAsSvg',
        'export_text_input_form_field_as_text' => 'setExportTextInputFormFieldAsText',
        'export_toc_page_numbers' => 'setExportTocPageNumbers',
        'export_xhtml_transitional' => 'setExportXhtmlTransitional',
        'fonts_folder' => 'setFontsFolder',
        'fonts_folder_alias' => 'setFontsFolderAlias',
        'font_resources_subsetting_size_threshold' => 'setFontResourcesSubsettingSizeThreshold',
        'html_version' => 'setHtmlVersion',
        'images_folder' => 'setImagesFolder',
        'images_folder_alias' => 'setImagesFolderAlias',
        'image_resolution' => 'setImageResolution',
        'office_math_output_mode' => 'setOfficeMathOutputMode',
        'resource_folder' => 'setResourceFolder',
        'resource_folder_alias' => 'setResourceFolderAlias',
        'scale_image_to_shape_size' => 'setScaleImageToShapeSize',
        'table_width_output_mode' => 'setTableWidthOutputMode',
        'export_drop_down_form_field_as_text' => 'setExportDropDownFormFieldAsText'
    ];

    /*
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'pretty_format' => 'getPrettyFormat',
        'allow_negative_indent' => 'getAllowNegativeIndent',
        'css_style_sheet_file_name' => 'getCssStyleSheetFileName',
        'css_style_sheet_type' => 'getCssStyleSheetType',
        'document_split_criteria' => 'getDocumentSplitCriteria',
        'document_split_heading_level' => 'getDocumentSplitHeadingLevel',
        'encoding' => 'getEncoding',
        'export_document_properties' => 'getExportDocumentProperties',
        'export_fonts_as_base64' => 'getExportFontsAsBase64',
        'export_font_resources' => 'getExportFontResources',
        'export_headers_footers_mode' => 'getExportHeadersFootersMode',
        'export_images_as_base64' => 'getExportImagesAsBase64',
        'export_language_information' => 'getExportLanguageInformation',
        'export_list_labels' => 'getExportListLabels',
        'export_metafile_as_raster' => 'getExportMetafileAsRaster',
        'export_original_url_for_linked_images' => 'getExportOriginalUrlForLinkedImages',
        'export_page_margins' => 'getExportPageMargins',
        'export_page_setup' => 'getExportPageSetup',
        'export_relative_font_size' => 'getExportRelativeFontSize',
        'export_roundtrip_information' => 'getExportRoundtripInformation',
        'export_text_box_as_svg' => 'getExportTextBoxAsSvg',
        'export_text_input_form_field_as_text' => 'getExportTextInputFormFieldAsText',
        'export_toc_page_numbers' => 'getExportTocPageNumbers',
        'export_xhtml_transitional' => 'getExportXhtmlTransitional',
        'fonts_folder' => 'getFontsFolder',
        'fonts_folder_alias' => 'getFontsFolderAlias',
        'font_resources_subsetting_size_threshold' => 'getFontResourcesSubsettingSizeThreshold',
        'html_version' => 'getHtmlVersion',
        'images_folder' => 'getImagesFolder',
        'images_folder_alias' => 'getImagesFolderAlias',
        'image_resolution' => 'getImageResolution',
        'office_math_output_mode' => 'getOfficeMathOutputMode',
        'resource_folder' => 'getResourceFolder',
        'resource_folder_alias' => 'getResourceFolderAlias',
        'scale_image_to_shape_size' => 'getScaleImageToShapeSize',
        'table_width_output_mode' => 'getTableWidthOutputMode',
        'export_drop_down_form_field_as_text' => 'getExportDropDownFormFieldAsText'
    ];

    /*
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return parent::attributeMap() + self::$attributeMap;
    }

    /*
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return parent::setters() + self::$setters;
    }

    /*
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return parent::getters() + self::$getters;
    }

    /*
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    const HTML_VERSION_XHTML = 'Xhtml';
    const HTML_VERSION_HTML5 = 'Html5';
    const OFFICE_MATH_OUTPUT_MODE_IMAGE = 'Image';
    const OFFICE_MATH_OUTPUT_MODE_MATH_ML = 'MathML';
    const OFFICE_MATH_OUTPUT_MODE_TEXT = 'Text';
    

    
    /*
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getHtmlVersionAllowableValues()
    {
        return [
            self::HTML_VERSION_XHTML,
            self::HTML_VERSION_HTML5,
        ];
    }
    
    /*
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getOfficeMathOutputModeAllowableValues()
    {
        return [
            self::OFFICE_MATH_OUTPUT_MODE_IMAGE,
            self::OFFICE_MATH_OUTPUT_MODE_MATH_ML,
            self::OFFICE_MATH_OUTPUT_MODE_TEXT,
        ];
    }
    


    /*
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        parent::__construct($data);

        $this->container['pretty_format'] = isset($data['pretty_format']) ? $data['pretty_format'] : null;
        $this->container['allow_negative_indent'] = isset($data['allow_negative_indent']) ? $data['allow_negative_indent'] : null;
        $this->container['css_style_sheet_file_name'] = isset($data['css_style_sheet_file_name']) ? $data['css_style_sheet_file_name'] : null;
        $this->container['css_style_sheet_type'] = isset($data['css_style_sheet_type']) ? $data['css_style_sheet_type'] : null;
        $this->container['document_split_criteria'] = isset($data['document_split_criteria']) ? $data['document_split_criteria'] : null;
        $this->container['document_split_heading_level'] = isset($data['document_split_heading_level']) ? $data['document_split_heading_level'] : null;
        $this->container['encoding'] = isset($data['encoding']) ? $data['encoding'] : null;
        $this->container['export_document_properties'] = isset($data['export_document_properties']) ? $data['export_document_properties'] : null;
        $this->container['export_fonts_as_base64'] = isset($data['export_fonts_as_base64']) ? $data['export_fonts_as_base64'] : null;
        $this->container['export_font_resources'] = isset($data['export_font_resources']) ? $data['export_font_resources'] : null;
        $this->container['export_headers_footers_mode'] = isset($data['export_headers_footers_mode']) ? $data['export_headers_footers_mode'] : null;
        $this->container['export_images_as_base64'] = isset($data['export_images_as_base64']) ? $data['export_images_as_base64'] : null;
        $this->container['export_language_information'] = isset($data['export_language_information']) ? $data['export_language_information'] : null;
        $this->container['export_list_labels'] = isset($data['export_list_labels']) ? $data['export_list_labels'] : null;
        $this->container['export_metafile_as_raster'] = isset($data['export_metafile_as_raster']) ? $data['export_metafile_as_raster'] : null;
        $this->container['export_original_url_for_linked_images'] = isset($data['export_original_url_for_linked_images']) ? $data['export_original_url_for_linked_images'] : null;
        $this->container['export_page_margins'] = isset($data['export_page_margins']) ? $data['export_page_margins'] : null;
        $this->container['export_page_setup'] = isset($data['export_page_setup']) ? $data['export_page_setup'] : null;
        $this->container['export_relative_font_size'] = isset($data['export_relative_font_size']) ? $data['export_relative_font_size'] : null;
        $this->container['export_roundtrip_information'] = isset($data['export_roundtrip_information']) ? $data['export_roundtrip_information'] : null;
        $this->container['export_text_box_as_svg'] = isset($data['export_text_box_as_svg']) ? $data['export_text_box_as_svg'] : null;
        $this->container['export_text_input_form_field_as_text'] = isset($data['export_text_input_form_field_as_text']) ? $data['export_text_input_form_field_as_text'] : null;
        $this->container['export_toc_page_numbers'] = isset($data['export_toc_page_numbers']) ? $data['export_toc_page_numbers'] : null;
        $this->container['export_xhtml_transitional'] = isset($data['export_xhtml_transitional']) ? $data['export_xhtml_transitional'] : null;
        $this->container['fonts_folder'] = isset($data['fonts_folder']) ? $data['fonts_folder'] : null;
        $this->container['fonts_folder_alias'] = isset($data['fonts_folder_alias']) ? $data['fonts_folder_alias'] : null;
        $this->container['font_resources_subsetting_size_threshold'] = isset($data['font_resources_subsetting_size_threshold']) ? $data['font_resources_subsetting_size_threshold'] : null;
        $this->container['html_version'] = isset($data['html_version']) ? $data['html_version'] : null;
        $this->container['images_folder'] = isset($data['images_folder']) ? $data['images_folder'] : null;
        $this->container['images_folder_alias'] = isset($data['images_folder_alias']) ? $data['images_folder_alias'] : null;
        $this->container['image_resolution'] = isset($data['image_resolution']) ? $data['image_resolution'] : null;
        $this->container['office_math_output_mode'] = isset($data['office_math_output_mode']) ? $data['office_math_output_mode'] : null;
        $this->container['resource_folder'] = isset($data['resource_folder']) ? $data['resource_folder'] : null;
        $this->container['resource_folder_alias'] = isset($data['resource_folder_alias']) ? $data['resource_folder_alias'] : null;
        $this->container['scale_image_to_shape_size'] = isset($data['scale_image_to_shape_size']) ? $data['scale_image_to_shape_size'] : null;
        $this->container['table_width_output_mode'] = isset($data['table_width_output_mode']) ? $data['table_width_output_mode'] : null;
        $this->container['export_drop_down_form_field_as_text'] = isset($data['export_drop_down_form_field_as_text']) ? $data['export_drop_down_form_field_as_text'] : null;
    }

    /*
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = parent::listInvalidProperties();

        $allowedValues = $this->getHtmlVersionAllowableValues();
        if (!in_array($this->container['html_version'], $allowedValues)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'html_version', must be one of '%s'",
                implode("', '", $allowedValues)
            );
        }

        $allowedValues = $this->getOfficeMathOutputModeAllowableValues();
        if (!in_array($this->container['office_math_output_mode'], $allowedValues)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'office_math_output_mode', must be one of '%s'",
                implode("', '", $allowedValues)
            );
        }

        return $invalidProperties;
    }

    /*
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        if (!parent::valid()) {
            return false;
        }

        $allowedValues = $this->getHtmlVersionAllowableValues();
        if (!in_array($this->container['html_version'], $allowedValues)) {
            return false;
        }
        $allowedValues = $this->getOfficeMathOutputModeAllowableValues();
        if (!in_array($this->container['office_math_output_mode'], $allowedValues)) {
            return false;
        }
        return true;
    }


    /*
     * Gets pretty_format
     *
     * @return bool
     */
    public function getPrettyFormat()
    {
        return $this->container['pretty_format'];
    }

    /*
     * Sets pretty_format
     *
     * @param bool $pretty_format Specifies whether or not use pretty formats output
     *
     * @return $this
     */
    public function setPrettyFormat($pretty_format)
    {
        $this->container['pretty_format'] = $pretty_format;

        return $this;
    }

    /*
     * Gets allow_negative_indent
     *
     * @return bool
     */
    public function getAllowNegativeIndent()
    {
        return $this->container['allow_negative_indent'];
    }

    /*
     * Sets allow_negative_indent
     *
     * @param bool $allow_negative_indent Specifies whether negative left and right indents of paragraphs are allowed (not normalized)
     *
     * @return $this
     */
    public function setAllowNegativeIndent($allow_negative_indent)
    {
        $this->container['allow_negative_indent'] = $allow_negative_indent;

        return $this;
    }

    /*
     * Gets css_style_sheet_file_name
     *
     * @return string
     */
    public function getCssStyleSheetFileName()
    {
        return $this->container['css_style_sheet_file_name'];
    }

    /*
     * Sets css_style_sheet_file_name
     *
     * @param string $css_style_sheet_file_name Specifies the name of the CSS file written when the document is exported to HTML
     *
     * @return $this
     */
    public function setCssStyleSheetFileName($css_style_sheet_file_name)
    {
        $this->container['css_style_sheet_file_name'] = $css_style_sheet_file_name;

        return $this;
    }

    /*
     * Gets css_style_sheet_type
     *
     * @return string
     */
    public function getCssStyleSheetType()
    {
        return $this->container['css_style_sheet_type'];
    }

    /*
     * Sets css_style_sheet_type
     *
     * @param string $css_style_sheet_type Specifies how CSS styles are exported
     *
     * @return $this
     */
    public function setCssStyleSheetType($css_style_sheet_type)
    {
        $this->container['css_style_sheet_type'] = $css_style_sheet_type;

        return $this;
    }

    /*
     * Gets document_split_criteria
     *
     * @return string
     */
    public function getDocumentSplitCriteria()
    {
        return $this->container['document_split_criteria'];
    }

    /*
     * Sets document_split_criteria
     *
     * @param string $document_split_criteria Specifies how the document should be split when saving
     *
     * @return $this
     */
    public function setDocumentSplitCriteria($document_split_criteria)
    {
        $this->container['document_split_criteria'] = $document_split_criteria;

        return $this;
    }

    /*
     * Gets document_split_heading_level
     *
     * @return int
     */
    public function getDocumentSplitHeadingLevel()
    {
        return $this->container['document_split_heading_level'];
    }

    /*
     * Sets document_split_heading_level
     *
     * @param int $document_split_heading_level Specifies the maximum level of headings at which to split the document
     *
     * @return $this
     */
    public function setDocumentSplitHeadingLevel($document_split_heading_level)
    {
        $this->container['document_split_heading_level'] = $document_split_heading_level;

        return $this;
    }

    /*
     * Gets encoding
     *
     * @return string
     */
    public function getEncoding()
    {
        return $this->container['encoding'];
    }

    /*
     * Sets encoding
     *
     * @param string $encoding Specifies the encoding to use when exporting
     *
     * @return $this
     */
    public function setEncoding($encoding)
    {
        $this->container['encoding'] = $encoding;

        return $this;
    }

    /*
     * Gets export_document_properties
     *
     * @return bool
     */
    public function getExportDocumentProperties()
    {
        return $this->container['export_document_properties'];
    }

    /*
     * Sets export_document_properties
     *
     * @param bool $export_document_properties Specifies whether to export built-in and custom document properties
     *
     * @return $this
     */
    public function setExportDocumentProperties($export_document_properties)
    {
        $this->container['export_document_properties'] = $export_document_properties;

        return $this;
    }

    /*
     * Gets export_fonts_as_base64
     *
     * @return bool
     */
    public function getExportFontsAsBase64()
    {
        return $this->container['export_fonts_as_base64'];
    }

    /*
     * Sets export_fonts_as_base64
     *
     * @param bool $export_fonts_as_base64 Specifies whether fonts resources should be embedded to HTML in Base64 encoding.  Default is false.
     *
     * @return $this
     */
    public function setExportFontsAsBase64($export_fonts_as_base64)
    {
        $this->container['export_fonts_as_base64'] = $export_fonts_as_base64;

        return $this;
    }

    /*
     * Gets export_font_resources
     *
     * @return bool
     */
    public function getExportFontResources()
    {
        return $this->container['export_font_resources'];
    }

    /*
     * Sets export_font_resources
     *
     * @param bool $export_font_resources Specifies whether font resources should be exported
     *
     * @return $this
     */
    public function setExportFontResources($export_font_resources)
    {
        $this->container['export_font_resources'] = $export_font_resources;

        return $this;
    }

    /*
     * Gets export_headers_footers_mode
     *
     * @return string
     */
    public function getExportHeadersFootersMode()
    {
        return $this->container['export_headers_footers_mode'];
    }

    /*
     * Sets export_headers_footers_mode
     *
     * @param string $export_headers_footers_mode Specifies how headers and footers are output
     *
     * @return $this
     */
    public function setExportHeadersFootersMode($export_headers_footers_mode)
    {
        $this->container['export_headers_footers_mode'] = $export_headers_footers_mode;

        return $this;
    }

    /*
     * Gets export_images_as_base64
     *
     * @return bool
     */
    public function getExportImagesAsBase64()
    {
        return $this->container['export_images_as_base64'];
    }

    /*
     * Sets export_images_as_base64
     *
     * @param bool $export_images_as_base64 Specifies whether images are saved in Base64 format
     *
     * @return $this
     */
    public function setExportImagesAsBase64($export_images_as_base64)
    {
        $this->container['export_images_as_base64'] = $export_images_as_base64;

        return $this;
    }

    /*
     * Gets export_language_information
     *
     * @return bool
     */
    public function getExportLanguageInformation()
    {
        return $this->container['export_language_information'];
    }

    /*
     * Sets export_language_information
     *
     * @param bool $export_language_information Specifies whether language information is exported
     *
     * @return $this
     */
    public function setExportLanguageInformation($export_language_information)
    {
        $this->container['export_language_information'] = $export_language_information;

        return $this;
    }

    /*
     * Gets export_list_labels
     *
     * @return string
     */
    public function getExportListLabels()
    {
        return $this->container['export_list_labels'];
    }

    /*
     * Sets export_list_labels
     *
     * @param string $export_list_labels Controls how list labels are output
     *
     * @return $this
     */
    public function setExportListLabels($export_list_labels)
    {
        $this->container['export_list_labels'] = $export_list_labels;

        return $this;
    }

    /*
     * Gets export_metafile_as_raster
     *
     * @return bool
     */
    public function getExportMetafileAsRaster()
    {
        return $this->container['export_metafile_as_raster'];
    }

    /*
     * Sets export_metafile_as_raster
     *
     * @param bool $export_metafile_as_raster Specifies whether to convert metafiles into raster images when exporting
     *
     * @return $this
     */
    public function setExportMetafileAsRaster($export_metafile_as_raster)
    {
        $this->container['export_metafile_as_raster'] = $export_metafile_as_raster;

        return $this;
    }

    /*
     * Gets export_original_url_for_linked_images
     *
     * @return bool
     */
    public function getExportOriginalUrlForLinkedImages()
    {
        return $this->container['export_original_url_for_linked_images'];
    }

    /*
     * Sets export_original_url_for_linked_images
     *
     * @param bool $export_original_url_for_linked_images Specifies whether original URL should be used as the URL of the linked images. Default value is false.
     *
     * @return $this
     */
    public function setExportOriginalUrlForLinkedImages($export_original_url_for_linked_images)
    {
        $this->container['export_original_url_for_linked_images'] = $export_original_url_for_linked_images;

        return $this;
    }

    /*
     * Gets export_page_margins
     *
     * @return bool
     */
    public function getExportPageMargins()
    {
        return $this->container['export_page_margins'];
    }

    /*
     * Sets export_page_margins
     *
     * @param bool $export_page_margins Specifies whether page margins is exported to HTML, MHTML or EPUB. Default is false.
     *
     * @return $this
     */
    public function setExportPageMargins($export_page_margins)
    {
        $this->container['export_page_margins'] = $export_page_margins;

        return $this;
    }

    /*
     * Gets export_page_setup
     *
     * @return bool
     */
    public function getExportPageSetup()
    {
        return $this->container['export_page_setup'];
    }

    /*
     * Sets export_page_setup
     *
     * @param bool $export_page_setup Specifies whether page setup is exported
     *
     * @return $this
     */
    public function setExportPageSetup($export_page_setup)
    {
        $this->container['export_page_setup'] = $export_page_setup;

        return $this;
    }

    /*
     * Gets export_relative_font_size
     *
     * @return bool
     */
    public function getExportRelativeFontSize()
    {
        return $this->container['export_relative_font_size'];
    }

    /*
     * Sets export_relative_font_size
     *
     * @param bool $export_relative_font_size Specifies whether font sizes should be output in relative units when saving
     *
     * @return $this
     */
    public function setExportRelativeFontSize($export_relative_font_size)
    {
        $this->container['export_relative_font_size'] = $export_relative_font_size;

        return $this;
    }

    /*
     * Gets export_roundtrip_information
     *
     * @return bool
     */
    public function getExportRoundtripInformation()
    {
        return $this->container['export_roundtrip_information'];
    }

    /*
     * Sets export_roundtrip_information
     *
     * @param bool $export_roundtrip_information Specifies whether to write the roundtrip information when saving to HTML Default value is true.
     *
     * @return $this
     */
    public function setExportRoundtripInformation($export_roundtrip_information)
    {
        $this->container['export_roundtrip_information'] = $export_roundtrip_information;

        return $this;
    }

    /*
     * Gets export_text_box_as_svg
     *
     * @return bool
     */
    public function getExportTextBoxAsSvg()
    {
        return $this->container['export_text_box_as_svg'];
    }

    /*
     * Sets export_text_box_as_svg
     *
     * @param bool $export_text_box_as_svg Controls how textboxes represented by Aspose.Words.Drawing.Shape are saved to HTML, MHTML or EPUB. Default value is false.    When set to true, exports textboxes as inline \"svg\" elements. When false, exports as \"image\" elements.
     *
     * @return $this
     */
    public function setExportTextBoxAsSvg($export_text_box_as_svg)
    {
        $this->container['export_text_box_as_svg'] = $export_text_box_as_svg;

        return $this;
    }

    /*
     * Gets export_text_input_form_field_as_text
     *
     * @return bool
     */
    public function getExportTextInputFormFieldAsText()
    {
        return $this->container['export_text_input_form_field_as_text'];
    }

    /*
     * Sets export_text_input_form_field_as_text
     *
     * @param bool $export_text_input_form_field_as_text Controls how text input form fields are saved
     *
     * @return $this
     */
    public function setExportTextInputFormFieldAsText($export_text_input_form_field_as_text)
    {
        $this->container['export_text_input_form_field_as_text'] = $export_text_input_form_field_as_text;

        return $this;
    }

    /*
     * Gets export_toc_page_numbers
     *
     * @return bool
     */
    public function getExportTocPageNumbers()
    {
        return $this->container['export_toc_page_numbers'];
    }

    /*
     * Sets export_toc_page_numbers
     *
     * @param bool $export_toc_page_numbers Specifies whether to write page numbers to table of contents when saving
     *
     * @return $this
     */
    public function setExportTocPageNumbers($export_toc_page_numbers)
    {
        $this->container['export_toc_page_numbers'] = $export_toc_page_numbers;

        return $this;
    }

    /*
     * Gets export_xhtml_transitional
     *
     * @return bool
     */
    public function getExportXhtmlTransitional()
    {
        return $this->container['export_xhtml_transitional'];
    }

    /*
     * Sets export_xhtml_transitional
     *
     * @param bool $export_xhtml_transitional Specifies whether to write the DOCTYPE declaration when saving
     *
     * @return $this
     */
    public function setExportXhtmlTransitional($export_xhtml_transitional)
    {
        $this->container['export_xhtml_transitional'] = $export_xhtml_transitional;

        return $this;
    }

    /*
     * Gets fonts_folder
     *
     * @return string
     */
    public function getFontsFolder()
    {
        return $this->container['fonts_folder'];
    }

    /*
     * Sets fonts_folder
     *
     * @param string $fonts_folder Specifies the physical folder where fonts are saved when exporting a document
     *
     * @return $this
     */
    public function setFontsFolder($fonts_folder)
    {
        $this->container['fonts_folder'] = $fonts_folder;

        return $this;
    }

    /*
     * Gets fonts_folder_alias
     *
     * @return string
     */
    public function getFontsFolderAlias()
    {
        return $this->container['fonts_folder_alias'];
    }

    /*
     * Sets fonts_folder_alias
     *
     * @param string $fonts_folder_alias Specifies the name of the folder used to construct font URIs
     *
     * @return $this
     */
    public function setFontsFolderAlias($fonts_folder_alias)
    {
        $this->container['fonts_folder_alias'] = $fonts_folder_alias;

        return $this;
    }

    /*
     * Gets font_resources_subsetting_size_threshold
     *
     * @return int
     */
    public function getFontResourcesSubsettingSizeThreshold()
    {
        return $this->container['font_resources_subsetting_size_threshold'];
    }

    /*
     * Sets font_resources_subsetting_size_threshold
     *
     * @param int $font_resources_subsetting_size_threshold Controls which font resources need subsetting when saving
     *
     * @return $this
     */
    public function setFontResourcesSubsettingSizeThreshold($font_resources_subsetting_size_threshold)
    {
        $this->container['font_resources_subsetting_size_threshold'] = $font_resources_subsetting_size_threshold;

        return $this;
    }

    /*
     * Gets html_version
     *
     * @return string
     */
    public function getHtmlVersion()
    {
        return $this->container['html_version'];
    }

    /*
     * Sets html_version
     *
     * @param string $html_version Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.   Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
     *
     * @return $this
     */
    public function setHtmlVersion($html_version)
    {
        $allowedValues = $this->getHtmlVersionAllowableValues();
        if ((!is_numeric($html_version) && !in_array($html_version, $allowedValues)) || (is_numeric($html_version) && !in_array($allowedValues[$html_version], $allowedValues))) {
            throw new \InvalidArgumentException(sprintf("Invalid value for 'html_version', must be one of '%s'", implode("', '", $allowedValues)));
        }
			
        $this->container['html_version'] = $html_version;

        return $this;
    }

    /*
     * Gets images_folder
     *
     * @return string
     */
    public function getImagesFolder()
    {
        return $this->container['images_folder'];
    }

    /*
     * Sets images_folder
     *
     * @param string $images_folder Specifies the physical folder where images are saved when exporting a document
     *
     * @return $this
     */
    public function setImagesFolder($images_folder)
    {
        $this->container['images_folder'] = $images_folder;

        return $this;
    }

    /*
     * Gets images_folder_alias
     *
     * @return string
     */
    public function getImagesFolderAlias()
    {
        return $this->container['images_folder_alias'];
    }

    /*
     * Sets images_folder_alias
     *
     * @param string $images_folder_alias Specifies the name of the folder used to construct image URIs
     *
     * @return $this
     */
    public function setImagesFolderAlias($images_folder_alias)
    {
        $this->container['images_folder_alias'] = $images_folder_alias;

        return $this;
    }

    /*
     * Gets image_resolution
     *
     * @return int
     */
    public function getImageResolution()
    {
        return $this->container['image_resolution'];
    }

    /*
     * Sets image_resolution
     *
     * @param int $image_resolution Specifies the output resolution for images when exporting
     *
     * @return $this
     */
    public function setImageResolution($image_resolution)
    {
        $this->container['image_resolution'] = $image_resolution;

        return $this;
    }

    /*
     * Gets office_math_output_mode
     *
     * @return string
     */
    public function getOfficeMathOutputMode()
    {
        return $this->container['office_math_output_mode'];
    }

    /*
     * Sets office_math_output_mode
     *
     * @param string $office_math_output_mode Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.
     *
     * @return $this
     */
    public function setOfficeMathOutputMode($office_math_output_mode)
    {
        $allowedValues = $this->getOfficeMathOutputModeAllowableValues();
        if ((!is_numeric($office_math_output_mode) && !in_array($office_math_output_mode, $allowedValues)) || (is_numeric($office_math_output_mode) && !in_array($allowedValues[$office_math_output_mode], $allowedValues))) {
            throw new \InvalidArgumentException(sprintf("Invalid value for 'office_math_output_mode', must be one of '%s'", implode("', '", $allowedValues)));
        }
			
        $this->container['office_math_output_mode'] = $office_math_output_mode;

        return $this;
    }

    /*
     * Gets resource_folder
     *
     * @return string
     */
    public function getResourceFolder()
    {
        return $this->container['resource_folder'];
    }

    /*
     * Sets resource_folder
     *
     * @param string $resource_folder Specifies a physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. Default is an empty string.
     *
     * @return $this
     */
    public function setResourceFolder($resource_folder)
    {
        $this->container['resource_folder'] = $resource_folder;

        return $this;
    }

    /*
     * Gets resource_folder_alias
     *
     * @return string
     */
    public function getResourceFolderAlias()
    {
        return $this->container['resource_folder_alias'];
    }

    /*
     * Sets resource_folder_alias
     *
     * @param string $resource_folder_alias Specifies the name of the folder used to construct URIs of all resources written into an HTML document.  Default is an empty string.
     *
     * @return $this
     */
    public function setResourceFolderAlias($resource_folder_alias)
    {
        $this->container['resource_folder_alias'] = $resource_folder_alias;

        return $this;
    }

    /*
     * Gets scale_image_to_shape_size
     *
     * @return bool
     */
    public function getScaleImageToShapeSize()
    {
        return $this->container['scale_image_to_shape_size'];
    }

    /*
     * Sets scale_image_to_shape_size
     *
     * @param bool $scale_image_to_shape_size Specifies whether images are scaled by Aspose.Words to the bounding shape size when exporting
     *
     * @return $this
     */
    public function setScaleImageToShapeSize($scale_image_to_shape_size)
    {
        $this->container['scale_image_to_shape_size'] = $scale_image_to_shape_size;

        return $this;
    }

    /*
     * Gets table_width_output_mode
     *
     * @return string
     */
    public function getTableWidthOutputMode()
    {
        return $this->container['table_width_output_mode'];
    }

    /*
     * Sets table_width_output_mode
     *
     * @param string $table_width_output_mode Controls how table, row and cell widths are exported
     *
     * @return $this
     */
    public function setTableWidthOutputMode($table_width_output_mode)
    {
        $this->container['table_width_output_mode'] = $table_width_output_mode;

        return $this;
    }

    /*
     * Gets export_drop_down_form_field_as_text
     *
     * @return bool
     */
    public function getExportDropDownFormFieldAsText()
    {
        return $this->container['export_drop_down_form_field_as_text'];
    }

    /*
     * Sets export_drop_down_form_field_as_text
     *
     * @param bool $export_drop_down_form_field_as_text Controls how drop-down form fields are saved to HTML. Default value is false.
     *
     * @return $this
     */
    public function setExportDropDownFormFieldAsText($export_drop_down_form_field_as_text)
    {
        $this->container['export_drop_down_form_field_as_text'] = $export_drop_down_form_field_as_text;

        return $this;
    }
    /*
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /*
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /*
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /*
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /*
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


