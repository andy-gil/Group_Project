   M S B A M L   `   `   `  ����H  DGroup Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:searchsearch  5   	   -clr-namespace:Group_ProjectGroup_Project  5   	       search.wndSearch   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:search     5   	   5Group_Projectclr-namespace:Group_Project     5   	   -   5          � Title$  	wndSearch��5	   	   $	��500��6   $	��800��6(    � 	Resources 5
      "   Group_Project.InvoiceDataSet   invoiceDataSet  itemDescViewSource �� Source �� Source  invoicesViewSource��%�   &	        &	      7   &	 A     7     5   
   6'   �� 5   
    6:   �� *
ItemDesc+8   �� 5   
    6:   �� *
Invoices+8   5      .��5      � ���	#FF130230 � DataContext# [ 6"   .+�5   
   �� -   5         ��Name$ InvoiceSelectedBtn��5      $��Select Invoice��6-   $
��Left=�6F   $��267,372,0,0q�6a   $	��Top=�6v   $	��135��6�   $��38��6�   $��14(�6�   $
��Bold"�6�   ���	#FFC6F0B26�   �� 5   
   -   5        $��Cancel��5      $
��Left=�6"   $��515,372,0,0q�6=   $	��Top=�6R   $	��135��6j   $��38��6v   $��14(�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ InvoiceTotalGB��5      $
��Left=�6+   $��
13,231,0,0q�6F   $	��Top=�6Z   $	��154��6r   $��36��6~   $��18(�6�   �� 5   
   -   5        $ InvoiceDateGB��5      $
��Left=�6*   $��
13,149,0,0q�6E   $	��Top=�6Y   $	��154��6q   $��36��6}   $��14(�6�   �� 5   
   $��Invoice Number��6   $
��Left=�6)   $��	13,32,0,0q�6D   $	��Top=�6W   $	��154��6o   $��18(�6{   $
��Bold"�6�   
�������6�   �� 5   
   $��Invoice Date��6   $
��Left=�6'   $��
13,115,0,0q�6B   $	��Top=�6V   $	��154��6n   $
��Bold"�6z   $��18(�6�   
�������6�   �� 5   
   $��Total Charge��6   $
��Left=�6'   $��
13,197,0,0q�6B   $	��Top=�6V   $	��154��6n   $
��Bold"�6z   $��18(�6�   
�������6�   �� 5   
   -   5        $ ClearBtn��5      $��Clear Filters��6#   $
��Left=�6;   $��
29,292,0,0q�6V   $	��Top=�6j   $	��119��6�   $��38��6�   $
��Bold"�6�   $��14(�6�   ���	#FFFD56566�   �� 5   
   -   5        $ InvoiceNumCB��5      $
��Left=�6)   $��	13,66,0,0q�6D   $	��Top=�6W   $	��154��6o   $��36��6{   $��18(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridSearch��5      $
��Left=�6+   $	��298��6F   $��
201,32,0,0q�6S   $	��Top=�6g   $	��569��6   $��24(�6�   $��courier)�6�   5      5      5      