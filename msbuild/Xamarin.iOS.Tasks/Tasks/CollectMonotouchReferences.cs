﻿using Microsoft.Build.Definition;
	{

		const string MsBuildNamespace = "http://schemas.microsoft.com/developer/msbuild/2003";
		const string MonoTouchProjectGuid = "6BC8ED88-2882-458C-8E55-DFD12B67127B";
		const string MonoTouchUnifiedProjectGuid = "FEACFBD2-3405-455C-9665-78FE426C6842";

		#region Inputs

		public ITaskItem [] References { get; set; }

		#endregion


						using (var reader = XmlReader.Create (reference.ItemSpec))