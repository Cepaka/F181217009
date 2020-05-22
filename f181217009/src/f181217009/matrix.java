/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package f181217009;

import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author Freeware Sys
 */
public class matrix {
   public Double array[][];
    protected int rows;
    protected int columns;
    public matrix(int rows,int columns){
        array=new Double[rows][columns];
        
        for(int i=0;i<rows;i++)
            for(int j=0;j<columns;j++){
                double random = new Random().nextDouble();
                array[i][j]=0+(random*(9-0));
            }
        this.rows=rows;
        this.columns=columns;
    }
public matrix(){
        Scanner input=new Scanner(System.in);
        System.out.println("Enter number of rows: ");
        int rows=input.nextInt();
        System.out.println("Enter number of columns: ");
        int columns=input.nextInt();
        array=new Double[rows][columns];
        
        for(int i=0;i<rows;i++)
            for(int j=0;j<columns;j++){
                double random = new Random().nextDouble();
                array[i][j]=0+(random*(12-0));
            }
        this.rows=rows;
        this.columns=columns;
    }
    public void Print(){
        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                if(array[i][j]>=10){
                System.out.printf("%-11f", array[i][j]);
                }
                else{
                    System.out.printf("%-11f",array[i][j]);
                }
            }
        System.out.println();}
    }
    public static matrix ScalarMul(double n,matrix a){
        matrix b=new matrix(a.rows,a.columns);
        for(int i=0;i<b.rows;i++)
            for(int j=0;j<b.columns;j++)
                b.array[i][j]=a.array[i][j]*n;
        return b;
    }
    public static matrix MatrixSum(matrix a,matrix b){
        if(a.rows!=b.rows||a.columns!=b.columns||a.columns!=a.rows){
            throw new IllegalArgumentException("Matrices must be square and with equal dimeonsions");
        }
        else{
            
            matrix c=new matrix(a.rows,a.columns);
            for(int i=0;i<c.rows;i++)
                for(int j=0;j<c.columns;j++)
                    c.array[i][j]=a.array[i][j]+b.array[i][j];
            return c;
        }
        
    }
    public static matrix Transpose(matrix a){
        matrix c=new matrix(a.array[0].length,a.array.length);
        for(int i=0;i<a.array.length;i++)
            for(int j=0;j<a.array[0].length;j++)
                c.array[j][i]=a.array[i][j];
        return c;
    }
   public static matrix Multiplication(matrix a,matrix b){
        if(a.columns!=b.rows){
            throw new IllegalArgumentException("Matrix dimension missmatch");
        }
        matrix c=new matrix(a.rows,b.columns);
        for(int i=0;i<a.rows;i++)
            for(int j=0;j<b.columns;j++)
                c.array[i][j]=0.00000;
        for(int i=0;i<a.rows;i++){
            for(int j=0;j<b.columns;j++)
                for(int k=0;k<a.columns;k++)
                    c.array[i][j]+=a.array[i][k]*b.array[k][j];
        }
        return c;
    }
}

