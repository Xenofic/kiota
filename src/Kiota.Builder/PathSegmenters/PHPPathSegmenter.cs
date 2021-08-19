﻿using Kiota.Builder.Extensions;

namespace Kiota.Builder
{
    public class PHPPathSegmenter : CommonPathSegmenter
    {
        public PHPPathSegmenter(string rootPath, string clientNamespaceName) : base(rootPath, clientNamespaceName) { }
        public override string FileSuffix => ".php";
        public override string NormalizeNamespaceSegment(string segmentName) => segmentName.ToFirstCharacterUpperCase();
        public override string NormalizeFileName(CodeElement currentElement) => currentElement.Name.ToFirstCharacterUpperCase();
    }
}
