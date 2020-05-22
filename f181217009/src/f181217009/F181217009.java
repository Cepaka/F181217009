package f181217009;
import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Scanner;
import javax.swing.*;
public class F181217009 

{
    public static void main(String[] args) {
        System.out.println("Матрица А");
        matrix a=new matrix();
        System.out.println("Матрица Б");
        matrix b=new matrix();
      JFrame frame = new JFrame();
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setVisible(true);
      frame.setSize(200,200);
      frame.setLayout(null);
      JButton display=new JButton("Display");
      display.setBounds(5,5,100,40);
      frame.add(display);
      JButton transpose=new JButton("Transpose");
      transpose.setBounds(5,50,100,40);
      JButton scalarmultiplier=new JButton("Scalar multiplication");
      JButton AxB=new JButton("A multiplied by B");
      scalarmultiplier.setBounds(5,100,150,40);
      AxB.setBounds(110,5,150,40);
      JButton BxA=new JButton("B multiplied by A");
      BxA.setBounds(110,50,150,40);
      frame.add(BxA);
      frame.add(AxB);
      frame.add(scalarmultiplier);
      frame.add(transpose);
      display.addActionListener(new ActionListener() {
  public void actionPerformed(ActionEvent event) {
      JFrame dd=new JFrame("Матрици");
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[a.columns];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Колона А"+i;
      }
      JTable t1=new JTable(a.array,s1);
      String[] s2=new String[b.columns];
      for(int i=1;i<s2.length+1;i++){
          s2[i-1]="Колона Б"+i;
      }
      JTable t2=new JTable(b.array,s2);
      dd.add(new JScrollPane(t2),BorderLayout.CENTER);
      dd.add(new JScrollPane(t1),BorderLayout.NORTH);  
  }
});
      transpose.addActionListener(new ActionListener(){
          public void actionPerformed(ActionEvent event){
              JFrame dd=new JFrame("Транспонирани матрици");
              matrix c=matrix.Transpose(a);
              matrix d=matrix.Transpose(b);
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[c.array[0].length];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Транспонирана колона А"+i;
      }
      JTable t1=new JTable(c.array,s1);
      String[] s2=new String[d.array[0].length];
      for(int i=1;i<s2.length+1;i++){
          s2[i-1]="Транспонирана колона Б"+i;
      }
      JTable t2=new JTable(d.array,s2);
      dd.add(new JScrollPane(t2),BorderLayout.CENTER);
      dd.add(new JScrollPane(t1),BorderLayout.NORTH);
          }
      });
      scalarmultiplier.addActionListener(new ActionListener() {
  public void actionPerformed(ActionEvent event) {
      JFrame dd=new JFrame("Матрици умножени с число");
      Scanner input=new Scanner(System.in);
        System.out.println("Number to multiply by ");
        double number=input.nextDouble();
      matrix c=matrix.ScalarMul(number, a);
      matrix d=matrix.ScalarMul(number,b);
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[c.array[0].length];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Колона А"+i;
      }
      JTable t1=new JTable(c.array,s1);
      String[] s2=new String[d.array[0].length];
      for(int i=1;i<s2.length+1;i++){
          s2[i-1]="Колона Б"+i;
      }
      JTable t2=new JTable(d.array,s2);
      dd.add(new JScrollPane(t2),BorderLayout.CENTER);
      dd.add(new JScrollPane(t1),BorderLayout.NORTH);
      }
      });
      scalarmultiplier.addActionListener(new ActionListener() {
  public void actionPerformed(ActionEvent event) {
      JFrame dd=new JFrame("Матрици умножени с число");
      Scanner input=new Scanner(System.in);
        System.out.println("Number to multiply by ");
        double number=input.nextDouble();
      matrix c=matrix.ScalarMul(number, a);
      matrix d=matrix.ScalarMul(number,b);
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[c.array[0].length];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Колона А"+i;
      }
      JTable t1=new JTable(c.array,s1);
      String[] s2=new String[d.array[0].length];
      for(int i=1;i<s2.length+1;i++){
          s2[i-1]="Колона Б"+i;
      }
      JTable t2=new JTable(d.array,s2);
      dd.add(new JScrollPane(t2),BorderLayout.CENTER);
      dd.add(new JScrollPane(t1),BorderLayout.NORTH);
      }
      });
      AxB.addActionListener(new ActionListener() {
  public void actionPerformed(ActionEvent event) {
      JFrame dd=new JFrame("Матрица А умножена по матрица Б");
      matrix c=matrix.Multiplication(a, b);
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[c.array[0].length];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Колона А"+i;
      }
      JTable t1=new JTable(c.array,s1);
      dd.add(new JScrollPane(t1),BorderLayout.CENTER);
      }
      });
      BxA.addActionListener(new ActionListener() {
  public void actionPerformed(ActionEvent event) {
      JFrame dd=new JFrame("Матрица Б умножена по матрица А");
      matrix c=matrix.Multiplication(b, a);
      dd.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
      dd.setVisible(true);
      dd.setSize(200,200);
      String[] s1=new String[c.array[0].length];
      for(int i=1;i<s1.length+1;i++)
      {
          s1[i-1]="Колона А"+i;
      }
      JTable t1=new JTable(c.array,s1);
      dd.add(new JScrollPane(t1),BorderLayout.CENTER);
      }
      });
}
}

