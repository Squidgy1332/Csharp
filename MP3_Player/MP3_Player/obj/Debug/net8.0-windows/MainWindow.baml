   M S B A M L   `   `   `  ����E  AMP3_Player, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MP3_Player
MP3_Player  5   	       MP3_Player.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MP3_Player     5   	     � Title$  
MainWindow��5   	   $	��476��6   $	��839��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ MediaCommands.Play��5
      66     5   
   -   5        $ MediaCommands.Stop��5      66     5   
   -   5        $ ApplicationCommands.Open��5      6<     5   
   -   5        $  EditingCommands.TabForward��5      6>   .��5      � $��0,0,0,-6q�6   .+�5   
   �� -   5         ��Name$	 Img��5      $
��Left=�66   $	��203��6Q   $��170,105,0,0q�6^   $	��Top=�6s   $	��449��6�   ��6   �� *Cover+6�   �� 5   
   -   5         ��Name$ PlayB��5      $
��Play��6    $
��Left=�6/   $��218,354,0,0q�6J   $	��Top=�6_   $��66��6w   $��MediaCommands.Play��6�   �� 5   
   -   5        $ StopB��5      $
��Stop��6    $
��Left=�6/   $��353,354,0,0q�6J   $	��Top=�6_   $��66��6w   $��MediaCommands.Stop��6�   �� 5   
   -   5        $ FBrowse��5      $	��...��6"   $
��Left=�60   $��
459,73,0,0q�6K   $	��Top=�6_   $��47��6w   6�   �� 5   
   -	   5         ��Name$ 
Find_FileL��5      $��Select a MP3 file��6$   $
��Left=�6@   $��
308,48,0,0q�6[   $	��Top=�6o   �� 5   
   -
   5         ��Name$ F_Path��5      $
��Left=�6"   $��
308,79,0,0q�6=   $��FilePath��6Q   $	��Top=�6a   $	��120��6y   ${�False��6�   �� 5   
   -   5        $ DisplayData��5      $��	Song Data��6&   $
��Left=�6:   $��601,354,0,0q�6U   $	��Top=�6j   $��66��6�   $ ��EditingCommands.TabForward��6�   �� 5   
   -   5        $ EditB��5      $��	Edit Data��6    $
��Left=�64   $��507,354,0,0q�6O   $	��Top=�6d   $��66��6|   $��ApplicationCommands.Open��6�       MP3_Player.DisplaySongData  5   
   -   5          Name$ DisplaySongData��5       $y�Hidden=�69   o� 5   
   $��
5,0,10,423q�6   .@�5      m� $��ToolBar��6   $��22��6(   $��80��64   .@�5      m� -   5        $��MenuPlay��5   )   $
��Play��6    m� Command$ MediaCommands.Play��69   m� 5      $
��Stop��6   $ MediaCommands.Stop��6)   m� 5      $
��Info��6   $  EditingCommands.TabForward��6)   m� 5      $
��Edit��6   $ ApplicationCommands.Open��6)   5      5       5!      5"      