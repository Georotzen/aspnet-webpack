﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webpack {

	/// <summary>
	/// Options for webpack configuration.
	/// All the files are created based on the path that is returned from IHostingEnvironment.WebRootPath
	/// </summary>
	public class WebpackOptions {

		public WebpackOptions(
			string entryPoint = "app/index.js",
			string outputFileName = "bundle.js",
			bool handleStyles = true) {
			EntryPoint = entryPoint;
			OutputFileName = outputFileName;
			HandleStyles = handleStyles;
		}

		/// <summary>
		/// The relative path to applications root
		/// </summary>
		public string EntryPoint { get; set; }

		/// <summary>
		/// The file name of the output bundle
		/// In order to put the file in a different folder use a relative path e.g. js/webpackBundle.js
		/// If not specified is "bundle.js"
		/// </summary>
		public string OutputFileName { get; set; }

		/// <summary>
		/// Indicates if webpack should handle the styles
		/// </summary>
		public bool HandleStyles { get; set; }

		/// <summary>
		/// The type of the styles
		/// </summary>
		public StylesType StylesType { get; set; }

		/// <summary>
		/// Indicates if webpack should handle jsx files (Reactjs)
		/// In case the react components live inside js files this could remain false
		/// </summary>
		public bool HandleJsxFiles { get; set; }

		/// <summary>
		/// Indicates if webpack's development server should be launched
		/// </summary>
		public bool UseDevelopmentServer { get; set; }
	}

	public enum StylesType {
		Css,
		Less,
		Sass
	}
}