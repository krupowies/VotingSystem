   M S B A M L   `   `   `  ����D  @VotingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VotingWPF.ViewsVotingWPF.Views  5   	   $    VotingWPF.Views.AdminElections   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VotingWPF.Views     5   	     � Title$  AdminElections��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ AddEleButton��5
   (   $��Add Election��6   $
��Left=�6Y   $��
601,10,0,0q�6t   $	��Top=�6�   $	��129��6�   
����� �$��40��6�   �� 5   
   -   5        $ DeleteEleButton��5   +   $��Delete Election��6   $
��Left=�6b   $��
434,10,0,0q�6}   $	��Top=�6�   $	��128��6�   
����� �$��40��6�    J� RenderTransformOrigin$ 
0.735,0.51&�6�   �� 5   
   -   5        $ GoBackButton��5   #   $��Go Back��6   $��Right=�6T   $	��Top=�6p   $	��128��6�   
����� �$��40��6�   $ 
0.735,0.51&�6�   $��0,10,642.6,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ electionList��5      $
��Left=�6)      SelectionMode$ Single=�6D   $	��Top=�6\   $��10,55,-10.4,0q�6v   
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6<      Header$ Id��6I      HeaderStringFormat$  ��6U   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Id+6k     5      $ * 6?   $
 Name��6I   	 . 
 6%   �� *Name+6W     5      $ * 6A   $ Winner��6K   	 . 
 6%   �� *Winner+6[   5      5      5      