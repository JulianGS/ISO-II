package presentation;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JTextPane;
import javax.swing.JList;
import javax.swing.JScrollBar;
import javax.swing.AbstractListModel;

public class Spotif extends JFrame {

	private JPanel contentPane;
	private JTextField txtSearch;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Spotif frame = new Spotif();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Spotif() {
		setTitle("Spotif*");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtSearch = new JTextField();
		txtSearch.setText("Search");
		txtSearch.setBounds(10, 11, 414, 20);
		contentPane.add(txtSearch);
		txtSearch.setColumns(10);
		
		JTextPane txtpnVenenoLos = new JTextPane();
		txtpnVenenoLos.setText("Veneno - Los Chichos\r\nDon't Stay Here - Frames\r\nGolden Nights - Eau Rouge\r\nSmooth Criminal - Michael Jackson\r\nUnbreakable - Skillet\r\nWhere Is Love? - Oliver Hank Saunders and Sandy Ryerson\r\nRespect - Aretha Franklin\t\r\nMister Cellophane - Kurt Hummel\r\nI Kissed a Girl - Katy Perry\r\nSit Down, You're Rockin' the Boat - Guys and Dolls\r\nCan't Fight This Feeling - REO Speedwagon\tFinn Hudson");
		txtpnVenenoLos.setBounds(20, 40, 254, 210);
		contentPane.add(txtpnVenenoLos);
		
		JList list = new JList();
		list.setModel(new AbstractListModel() {
			String[] values = new String[] {"Buy Music", "-----------------", "Manage Playlist", "-----------------", "Account Settings", "-----------------"};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}
		});
		list.setBounds(284, 42, 91, 208);
		contentPane.add(list);
		
		JScrollBar scrollBar = new JScrollBar();
		scrollBar.setBounds(371, 40, 17, 210);
		contentPane.add(scrollBar);
	}
}
