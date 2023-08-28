using System;

namespace DNZ.SEOChecker
{
    internal enum ErrorMessage
    {
        // Title
        [MessageInfo(GroupName = "Title", Description = "Please enter a title for the page.")]
        TitleIsEmpty,
        [MessageInfo(GroupName = "Title", Description = "The title of the page has {1} characters, which is less than the recommended value of {2} characters.")] //{0}Title - {1}TitleLength - {2}TitleMinLength
        TitleIsShort,
        [MessageInfo(GroupName = "Title", Description = "The title of the page has {1} characters, which is more than the recommended value of {2} characters.")] //{0}Title - {1}TitleLength - {2}TitleMaxLength
        TitleIsLong,
        [MessageInfo(GroupName = "Title", Description = "The focused keyword is not present in the title of the page.")] //{0}Title - {1}Keyword
        TitleDoesNotContainFocusedKeyword,
        [MessageInfo(GroupName = "Title", Description = "The title of the page contains the focused keyword, but it is not at the beginning of the title. Please place it at the beginning of the title.")] //{0}Title - {1}Keyword
        TitleDoesNotStartWithFocusedKeyword,
        [MessageInfo(GroupName = "Title", Description = "The number of words in the title is {1}, which is more than the recommended maximum of {2} words.")] //{0}Title - {1}TitleWordsCount - {2}TitleWordsMaxCount
        TitleWordsAreMoreThan,
        [MessageInfo(GroupName = "Title", Description = "The number of words in the title is {1}, which is fewer than the recommended minimum of {2} words.")] //{0}Title - {1}TitleWordsCount - {2}TitleWordsMinCount
        TitleWordsAreFewerThan,
        [MessageInfo(GroupName = "Title", Description = "The title of the page is duplicate and has been used in previous posts.")] //{0}Title
        TitleDuplicated,
        [MessageInfo(GroupName = "Title", Description = "The similarity between the title and the meta description is {1}%, which is less than the recommended value of {2}%.")] //{0}Title - {1}CurrentDensity - {2}MinDensity
        TitleDoesNotMatchMetaDescription,
        [MessageInfo(GroupName = "Title", Description = "The similarity between the title and the content is {1}%, which is less than the recommended value of {2}%.")] //{0}Title - {1}CurrentDensity - {2}MinDensity
        TitleDoesNotMatchContent,


        // Keyword
        [MessageInfo(GroupName = "Keyword", Description = "No keyword has been specified for this page. Please select a relevant keyword from the text.")]
        KeywordIsEmpty,
        [MessageInfo(GroupName = "Keyword", Description = "The keyword \"{0}\" is duplicate and has been used in previous posts.")] //{0}Keyword
        KeywordDuplicated,
        [MessageInfo(GroupName = "Keyword", Description = "The keyword contains {2} highly generic words: {1}. Please remove them.")] //{0}Keyword - {1}StopWordsSentence - {2}StopWordsCount
        KeywordContainStopWords,

        // Meta Description
        [MessageInfo(GroupName = "MetaDescription", Description = "No meta description is specified. Search engines will display a portion of the page text instead.")]
        MetaDescriptionIsEmpty,
        [MessageInfo(GroupName = "MetaDescription", Description = "A meta description tag is defined, but the keyword \"{0}\" is not present in it.")] //{0}Keywords
        MetaDescriptionDoesNotContainFocusedKeyword,
        [MessageInfo(GroupName = "MetaDescription", Description = "The meta description tag has {0} characters, which is less than the recommended value of {1} characters.")] //{0}MetaDescLength - {1}MetaDescriptionMinLength
        MetaDescriptionIsShort,
        [MessageInfo(GroupName = "MetaDescription", Description = "{1} جمله در متاتگ توضیحات بیش از {2} کلمه دارد. لطفا آن را کاهش دهید.")]//{0}MetaDescSentencesCount - {1}MaxWordsSentencesCount - {2}MetaDescriptionSentencesWordsMaxCount
        MetaDescriptionContainSentencesMoreThanWords, 
        [MessageInfo(GroupName = "MetaDescription", Description = "The meta description tag has {0} characters, which is more than the recommended value of {1} characters.")] //{0}MetaDescLength - {1}MetaDescriptionMaxLength
        MetaDescriptionIsLong,
        [MessageInfo(GroupName = "MetaDescription", Description = "The meta description tag contains {0} words, which is more than the recommended maximum of {1} words.")] //{0}MetaDescWordsCount - {1}MetaDescriptionWordsMaxCount
        MetaDescriptionWordsAreMoreThan,
        [MessageInfo(GroupName = "MetaDescription", Description = "The meta description tag contains {0} words, which is fewer than the recommended minimum of {1} words.")] //{0}MetaDescWordsCount - {1}MetaDescriptionWordsMinCount
        MetaDescriptionWordsAreFewerThan,
        [MessageInfo(GroupName = "MetaDescription", Description = "The density of highly generic words ({2}) in the meta description tag is {0}%, which is more than the recommended value of {1}%. Please remove them.")] //{0}CurrentDensity - {1}MaxDensity - {2}StopWordsSentence
        MetaDescriptionContainMoreThanStopWords,
        [MessageInfo(GroupName = "MetaDescription", Description = "The similarity between the meta description and the content is {0}%, which is less than the recommended value of {1}%.")] //{0}CurrentDensity - {1}MinDensity
        MetaDescriptionDoesNotMatchContent,
        [MessageInfo(GroupName = "MetaDescription", Description = "The meta description is duplicate and has been used in previous posts.")]
        MetaDescriptionDuplicated,

        //Text
        [MessageInfo(GroupName = "Text", Description = "The text is empty, please enter some text.")]
        TextIsEmpty,
        [MessageInfo(GroupName = "Text", Description = "The text {0} has an HTML parsing error.")]//{0}HtmlParseErrorCount
        TextHasHtmlParseError,
        [MessageInfo(GroupName = "Text", Description = "The text contains HTML tags but no content.")]
        TextHasHtmlNotText,
        [MessageInfo(GroupName = "Text", Description = "The text has {0} characters, which is less than the recommended minimum of {1}.")]//{0}TextLenght - {1}TextMinLenght
        TextIsShort,
        [MessageInfo(GroupName = "Text", Description = "The text has {0} characters, which is more than the recommended maximum of {1}.")] //{0}TextLenght - {1}TextMaxLenght
        TextIsLong,
        [MessageInfo(GroupName = "Text", Description = "The text does not contain the focus keyword \"{0}\".")] //{0}Keyword
        TextDoesNotContainFocusKeyword,
        [MessageInfo(GroupName = "Text", Description = "The text does not contain a heading tag (h1).")]
        TextDoesNotContainHeading,
        [MessageInfo(GroupName = "Text", Description = "The text contains {0} heading tags (h1), reduce it to a single heading.")]
        TextContainMultipleHeading,
        [MessageInfo(GroupName = "Text", Description = "There are no subheading tags (H2, H3, etc.) in your text.")]
        TextDoesNotContainAnySubheadings,
        [MessageInfo(GroupName = "Text", Description = "The first subheading does not contain the keyword \"{0}\".")]
        TextFirstHeadingDoesContainKeyword,
        [MessageInfo(GroupName = "Text", Description = "You haven't used the keyword \"{0}\" in any of the subheadings (H2, H3, ...).")]
        TextSubHeadingsDoesContainKeyword,
        [MessageInfo(GroupName = "Text", Description = "There are {0} heading/subheading(s) in the text that have fewer than {1} characters.")] //{0}HeadAndSubheadingsAreFewerLenght - {1}TextSubheadingMinLenght - {2}0Sentences
        TextSubHeadingsContainFewerThanCharacters,
        [MessageInfo(GroupName = "Text", Description = "There are {0} heading/subheading(s) in the text that have more than {1} characters.")] //{0}HeadAndSubheadingsAreMoreLenght - {1}TextSubheadingMaxLenght - {2}0Sentences
        TextSubHeadingsContainMoreThanCharacters,
        [MessageInfo(GroupName = "Text", Description = "There are no paragraphs (p or div tags) in the text.")]
        TextDoesNotContainAnyParagraph,
        [MessageInfo(GroupName = "Text", Description = "There are no links (a tags) in the text.")]
        TextDoesNotContainAnyLinks,
        [MessageInfo(GroupName = "Text", Description = "There are {0} links in the text, which is fewer than the recommended minimum of {1}.")]//{0}LinkCount - {1}MinCount
        TextLinksAreFewerThan,
        [MessageInfo(GroupName = "Text", Description = "There are {0} links in the text, which is more than the recommended maximum of {1}.")]//{0}LinkCount - {1}MaxCount
        TextLinksAreMoreThan,
        [MessageInfo(GroupName = "Text", Description = "There are no internal links (links to your own site) in this text! Add one or more internal links relevant to site posts.")]
        TextDoesNotContainAnyInboundLinks,
        [MessageInfo(GroupName = "Text", Description = "There are no external links (links to other sites) in this text! Add one or more external links relevant to the content of the post to reputable sites.")]
        TextDoesNotContainAnyOutboundLinks,
        [MessageInfo(GroupName = "Text", Description = "The keyword density in the text is {2}%, which is lower than the recommended minimum of {3}%. Your keyword \"{0}\" appears {1} times in the text.")]
        TextKeywordDensityIsLow,
        [MessageInfo(GroupName = "Text", Description = "The keyword density in the text is {2}%, which is higher than the recommended maximum of {3}%. Your keyword \"{0}\" appears {1} times in the text.")]
        TextKeywordDensityIsHigh,
        [MessageInfo(GroupName = "Text", Description = "The word count of this text is {0}, which is fewer than the recommended minimum of {1}.")]
        TextWordsAreFewerThan,
        [MessageInfo(GroupName = "Text", Description = "The word count of this text is {0}, which is more than the recommended maximum of {1}.")]
        TextWordsAreMoreThan,
        [MessageInfo(GroupName = "Text", Description = "The density of very common words ({2}) in this text is {0}%, which is higher than the recommended maximum of {1}%.")]
        TextContainMoreThanStopWords,
        [MessageInfo(GroupName = "Text", Description = "The density of transition words in the text is {1}%, which is lower than the recommended minimum of {2}%. {0} sentence(s) in the text include transition words.")]
        TransitionSentencesAreFewerThan,

        //Sentence
        [MessageInfo(GroupName = "Text", Description = "{0} sentence(s) in the text contain more than {1} words, which is {2}% of text sentences, and this exceeds the recommended maximum of {3}%.")]
        TextAvgSentencesAreMoreThan,
        [MessageInfo(GroupName = "Text", Description = "{0} sentence(s) in the text contain more than the recommended maximum of {1} words.")]
        TextSentencesContainMoreThanWords,

        //Paragraph
        [MessageInfo(GroupName = "Text", Description = "{0} of the paragraphs (p or div tags) in the text have more than the recommended maximum of {1} words.")]
        ParagraphWordsAreMoreThan,
        [MessageInfo(GroupName = "Text", Description = "{0} of the paragraphs (p or div tags) in the text have fewer than the recommended minimum of {1} words.")]
        ParagraphWordsAreFewerThan,
        [MessageInfo(GroupName = "Text", Description = "The focus keyword \"{0}\" is not present in the first paragraph.")]
        FirstParagraphDoesNotContainFocusedKeyword,

        //Image
        [MessageInfo(GroupName = "Text", Description = "No images are found in this post. It might be better to add an image.")]
        TextDoesNotContainAnyImage,
        [MessageInfo(GroupName = "Text", Description = "{0} out of {1} images used in this text do not have an alt tag.")]
        ImagesDoesNotContainAltAttribute,
        [MessageInfo(GroupName = "Text", Description = "None of the {1} images used in this text have the keyword \"{0}\" in the alt attribute.")]
        NoImageContainKeywordInAltAttribute,
        [MessageInfo(GroupName = "Text", Description = "None of the {1} images used in this text have the keyword \"{0}\" in the file name (src attribute).")]
        NoImageContainKeywordInFielName,


        [MessageInfo(GroupName = "Url", Description = "The URL is empty, please enter a valid URL.")]
        UrlIsEmpty,
        [MessageInfo(GroupName = "Url", Description = "The URL contains {0} characters, which is less than the recommended minimum of {1} characters.")]
        UrlIsShort,
        [MessageInfo(GroupName = "Url", Description = "The URL contains {0} characters, which is more than the recommended maximum of {1} characters.")]
        UrlIsLong,
        [MessageInfo(GroupName = "Url", Description = "The focus keyword \"{1}\" is not included in the URL.")]
        UrlDoesNotContainFocusKeyword,
        [MessageInfo(GroupName = "Url", Description = "The URL contains {0} words, which is more than the recommended maximum of {1} words.")]
        UrlWordsAreMoreThan,
        [MessageInfo(GroupName = "Url", Description = "The URL contains {0} words, which is fewer than the recommended minimum of {1} words.")]
        UrlWordsAreFewerThan,
        [MessageInfo(GroupName = "Url", Description = "The URL includes one or more very common words ({2}), please remove them.")]
        UrlContainMoreThanStopWords,
        [MessageInfo(GroupName = "Url", Description = "The similarity between the URL and the meta description is {1}%, which is lower than the recommended minimum of {2}%.")]
        UrlDoesNotMatchMetaDescription,
        [MessageInfo(GroupName = "Url", Description = "The URL is duplicated and has been used in previous posts.")]
        UrlDuplicated,
        [MessageInfo(GroupName = "Url", Description = "The similarity between the URL and the content is {1}%, which is lower than the recommended minimum of {2}%.")]
        UrlDoesNotMatchContent,

    }

    [AttributeUsage(AttributeTargets.Field)]
    internal sealed class MessageInfoAttribute : Attribute
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}