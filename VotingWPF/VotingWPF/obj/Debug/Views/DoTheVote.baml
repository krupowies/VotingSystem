   M S B A M L   `   `   `  ����D  @VotingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VotingWPF.ViewsVotingWPF.Views  5   	       VotingWPF.Views.DoTheVote   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VotingWPF.Views     5   	     � Title$  	DoTheVote��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� $��Choose your answer : ��6   
���   �$��50(�6C   $��Center=�6Q   �� 5   
   -   5        $��Question��5      $�� ��6$   $��Center=�6,   $��172,70,173.6,288q�6I   $��30(�6c   $	��448��6q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ electionList��5      $
��Left=�6F      SelectionMode$ Single=�6a   $	��Top=�6y   
�������$��0,152,-0.4,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6?      Header$
 Name��6I      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6W     5      $ * 6C   $ LastName��6M    .  6%   �� *
LastName+6_   5      �� 5   
   -   5         ��Name$
 Vote��5   !   $��0��6   $��313,380,330.6,10q�6B   $��20(�6\   $
��Bold"�6j   $
��Vote��6|   $	��150��6�   $��30��6�   
����� �6�   5      5      