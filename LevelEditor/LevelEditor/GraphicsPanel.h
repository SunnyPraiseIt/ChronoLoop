#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;


namespace LevelEditor {

	/// <summary>
	/// Summary for GraphicsPanel
	/// </summary>
	public ref class GraphicsPanel : public System::Windows::Forms::Panel
	{
	public:
		GraphicsPanel(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			this->SetStyle(ControlStyles::UserPaint | ControlStyles::AllPaintingInWmPaint | ControlStyles::Opaque, true);
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~GraphicsPanel()
		{
			if (components)
			{
				delete components;
			}
		}
	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = gcnew System::ComponentModel::Container();
		}
#pragma endregion
	};
}
