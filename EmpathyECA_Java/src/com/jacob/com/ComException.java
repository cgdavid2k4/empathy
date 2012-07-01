/*
 * Copyright (c) 1999 Dan Adler, 315 E72 St. NY, NY, 10021, USA.
 * mailto:danadler@rcn.com. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in 
 *    the documentation and/or other materials provided with the
 *    distribution.
 * 3. Redistributions in any form must be accompanied by information on
 *    how to obtain complete source code for the JACOB software.
 *
 * Redistribution of the JACOB software is not permitted as part of any
 * commercial product that is targeted primarily at Java developers.
 * Such products include, but are not limited to: Java virtual machines,
 * integrated development environments, code libraries, and application
 * server products. Licensing terms for such distribution may be
 * obtained from the copyright holder.
 *
 * THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESS OR IMPLIED 
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
 * OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT
 * OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; 
 * OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT 
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
 * USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 */
package com.jacob.com;

public abstract class ComException extends RuntimeException
{
  // Fields
  protected int hr;
  protected int m_helpContext;
  protected String m_helpFile;
  protected String m_source;

  // Constructors
  public ComException()
  {
    super();
  }

  public ComException(int hr)
  {
    super();
    this.hr = hr;
  }

  public ComException(int hr, String description)
  {
    super(description);
    this.hr = hr;
  }

  public ComException(int hr, String source, String helpFile,
        int helpContext)
  {
    super();
    this.hr = hr;
    m_source = source;
    m_helpFile = helpFile;
    m_helpContext = helpContext;
  }

  public ComException(int hr, String description, String source,
        String helpFile, int helpContext)
  {
    super(description);
    this.hr = hr;
    m_source = source;
    m_helpFile = helpFile;
    m_helpContext = helpContext;
  }

  public ComException(String description)
  {
    super(description);
  }

  // Methods
  public int getHelpContext() { return m_helpContext; }
  public String getHelpFile() { return m_helpFile; }
  public int getHResult() { return hr; }
  public String getSource() { return m_source; }
}
